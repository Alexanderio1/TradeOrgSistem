using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения сведений о покупателях указанного товара.
    /// Фильтрация может осуществляться:
    /// - по периоду (если заданы startDate и endDate),
    /// - по товару (по ID; если не задан, то по имени; если и имени нет, то по типу),
    /// - по торговым точкам (по ID; если не задан, то по названию; если и названия нет, то по типу).
    /// Если никакие фильтры не заданы, используются данные по всем продажам.
    /// </summary>
    public class ProductCustomerQueryService
    {
        private readonly DataRepository _repository;

        public ProductCustomerQueryService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает сведения о покупателях указанного товара.
        /// Если задан productId, фильтрация по товару происходит по ID.
        /// Если productId не задан, но задан productName – производится поиск товара по названию (без учёта регистра).
        /// Если и productName не задан, но указан productType – используется фильтрация по типу товара.
        /// Аналогично для торговых точек: приоритет – retailLocationId > retailLocationName > retailLocationType.
        /// </summary>
        /// <param name="productId">
        /// ID товара (приоритетный параметр).
        /// </param>
        /// <param name="productName">
        /// Название товара (используется, если productId не задан).
        /// </param>
        /// <param name="productType">
        /// Тип товара (используется, если не заданы ни productId, ни productName).
        /// </param>
        /// <param name="startDate">
        /// Начало анализируемого периода (опционально).
        /// </param>
        /// <param name="endDate">
        /// Конец анализируемого периода (опционально).
        /// </param>
        /// <param name="retailLocationId">
        /// ID торговой точки (приоритетный параметр для фильтрации по месту продажи).
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки (используется, если retailLocationId не задан).
        /// </param>
        /// <param name="retailLocationType">
        /// Тип торговой точки (используется, если не заданы ни retailLocationId, ни retailLocationName).
        /// </param>
        /// <returns>
        /// Объект ProductCustomerQueryResult с перечнем покупателей и общим числом записей.
        /// </returns>
        public ProductCustomerQueryResult GetCustomersForProduct(
            int? productId,
            string productName,
            string productType,
            DateTime? startDate,
            DateTime? endDate,
            int? retailLocationId,
            string retailLocationName,
            string retailLocationType)
        {
            // Получаем все продажи из репозитория
            var sales = _repository.Data.Sales.AsEnumerable();

            // Фильтруем по периоду, если заданы даты
            if (startDate.HasValue)
                sales = sales.Where(s => s.Date >= startDate.Value);
            if (endDate.HasValue)
                sales = sales.Where(s => s.Date <= endDate.Value);

            // Фильтрация по товару:
            if (productId.HasValue)
            {
                sales = sales.Where(s => s.ProductId == productId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(productName))
            {
                sales = sales.Where(s => _repository.Data.Products.Any(p =>
                    p.Id == s.ProductId &&
                    p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)));
            }
            else if (!string.IsNullOrWhiteSpace(productType))
            {
                sales = sales.Where(s => _repository.Data.Products.Any(p =>
                    p.Id == s.ProductId &&
                    p.Type.Equals(productType, StringComparison.OrdinalIgnoreCase)));
            }

            // Фильтрация по торговым точкам:
            if (retailLocationId.HasValue)
            {
                sales = sales.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location != null)
                {
                    sales = sales.Where(s => s.RetailLocationId == location.Id);
                }
                else
                {
                    // Если торговая точка не найдена по названию, сбрасываем продажи
                    sales = Enumerable.Empty<Sale>();
                }
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }
            // Если ни один из фильтров по торговой точке не задан, используем продажи по всем торговым точкам

            // Из отфильтрованных продаж выбираем уникальные идентификаторы покупателей
            var customerIds = sales.Select(s => s.CustomerId).Distinct();

            // Получаем покупателей из репозитория по найденным ID
            var customers = _repository.Data.Customers.Where(c => customerIds.Contains(c.Id)).ToList();

            return new ProductCustomerQueryResult
            {
                Customers = customers,
                TotalCount = customers.Count
            };
        }
    }
}
