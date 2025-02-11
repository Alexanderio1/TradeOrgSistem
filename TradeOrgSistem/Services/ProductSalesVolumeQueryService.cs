using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения данных об объёме продаж указанного товара за заданный период.
    /// Фильтрация по торговым точкам может производиться:
    /// – по всем торговым точкам (если не задан ни retailLocationType, ни retailLocationId, ни retailLocationName),
    /// – по торговым точкам заданного типа,
    /// – по конкретной торговой точке (если задан retailLocationId или retailLocationName).
    /// Приоритет: retailLocationId > retailLocationName > retailLocationType.
    /// </summary>
    public class ProductSalesVolumeQueryService
    {
        private readonly DataRepository _repository;

        public ProductSalesVolumeQueryService()
        {
            // Используем Singleton-экземпляр DataRepository для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает данные об объёме продаж указанного товара за заданный период с фильтрацией по торговым точкам.
        /// </summary>
        /// <param name="productId">ID товара, для которого производится запрос.</param>
        /// <param name="startDate">Начало анализируемого периода.</param>
        /// <param name="endDate">Конец анализируемого периода.</param>
        /// <param name="retailLocationType">
        /// Тип торговой точки для фильтрации (используется, если не задан retailLocationId и retailLocationName).
        /// </param>
        /// <param name="retailLocationId">
        /// Конкретный ID торговой точки для фильтрации (приоритетный параметр).
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки для фильтрации (используется, если retailLocationId не задан).
        /// </param>
        /// <returns>
        /// Объект ProductSalesVolumeQueryResult, содержащий ID и название товара, а также суммарный объём продаж.
        /// </returns>
        public ProductSalesVolumeQueryResult GetProductSalesVolume(
            int productId,
            DateTime startDate,
            DateTime endDate,
            string retailLocationType,
            int? retailLocationId,
            string retailLocationName)
        {
            // Фильтруем продажи по заданному товару и периоду
            var sales = _repository.Data.Sales
                .Where(s => s.ProductId == productId && s.Date >= startDate && s.Date <= endDate);

            // Фильтрация по торговой точке:
            // 1. Если задан retailLocationId, фильтруем по нему.
            if (retailLocationId.HasValue)
            {
                sales = sales.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            // 2. Если retailLocationId не задан, но задано retailLocationName – ищем торговую точку по названию.
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
                    // Если торговая точка не найдена по названию, можно вернуть результат с нулевым объёмом
                    return new ProductSalesVolumeQueryResult
                    {
                        ProductId = productId,
                        ProductName = _repository.Data.Products.FirstOrDefault(p => p.Id == productId)?.Name ?? "Неизвестный товар",
                        TotalSalesVolume = 0
                    };
                }
            }
            // 3. Если ни retailLocationId, ни retailLocationName не заданы, но задан retailLocationType – фильтруем по типу торговой точки.
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }
            // Если ни один из параметров фильтрации не задан, используются продажи по всем торговым точкам.

            // Вычисляем суммарный объём продаж
            int totalVolume = sales.Sum(s => s.Volume);

            // Получаем данные о товаре для удобства отображения
            var product = _repository.Data.Products.FirstOrDefault(p => p.Id == productId);

            return new ProductSalesVolumeQueryResult
            {
                ProductId = productId,
                ProductName = product != null ? product.Name : "Неизвестный товар",
                TotalSalesVolume = totalVolume
            };
        }
    }
}
