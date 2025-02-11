using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;  
namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения сведений о поставках определённого товара указанным поставщиком.
    /// Можно задать фильтрацию за весь период или за указанный промежуток времени.
    /// Для удобства пользователя можно задавать поставщика и товар либо по ID, либо по имени.
    /// </summary>
    public class DeliveryQueryService
    {
        private readonly DataRepository _repository;

        public DeliveryQueryService()
        {
            // Используем Singleton-экземпляр для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает сведения о поставках определённого товара указанным поставщиком.
        /// Фильтрация производится по поставщикам и товарам с учётом:
        /// - Если задан supplierId, используется он; иначе ищется по supplierName.
        /// - Если задан productId, используется он; иначе ищется по productName.
        /// - Если заданы startDate и/или endDate, поставки фильтруются по периоду.
        /// </summary>
        /// <param name="supplierId">
        /// ID поставщика. Если не задан, то должен быть указан supplierName.
        /// </param>
        /// <param name="supplierName">
        /// Имя поставщика (поиск без учёта регистра), используется, если supplierId не задан.
        /// </param>
        /// <param name="productId">
        /// ID товара. Если не задан, то должен быть указан productName.
        /// </param>
        /// <param name="productName">
        /// Название товара (поиск без учёта регистра), используется, если productId не задан.
        /// </param>
        /// <param name="startDate">
        /// Начало периода для фильтрации поставок (опционально).
        /// </param>
        /// <param name="endDate">
        /// Конец периода для фильтрации поставок (опционально).
        /// </param>
        /// <returns>
        /// Объект DeliveryQueryResult, содержащий список поставок и общее число записей.
        /// </returns>
        public DeliveryQueryResult GetDeliveriesForSupplierAndProduct(
            int? supplierId, string supplierName,
            int? productId, string productName,
            DateTime? startDate, DateTime? endDate)
        {
            // Определяем поставщика: если supplierId не задан, ищем по имени
            if (!supplierId.HasValue)
            {
                if (string.IsNullOrWhiteSpace(supplierName))
                    throw new ArgumentException("Необходимо указать либо ID поставщика, либо его имя.", nameof(supplierName));

                var supplier = _repository.Data.Suppliers
                    .FirstOrDefault(s => s.Name.Equals(supplierName, StringComparison.OrdinalIgnoreCase));
                if (supplier == null)
                    throw new InvalidOperationException("Поставщик с указанным именем не найден.");
                supplierId = supplier.Id;
            }

            // Определяем товар: если productId не задан, ищем по названию
            if (!productId.HasValue)
            {
                if (string.IsNullOrWhiteSpace(productName))
                    throw new ArgumentException("Необходимо указать либо ID товара, либо его название.", nameof(productName));

                var product = _repository.Data.Products
                    .FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
                if (product == null)
                    throw new InvalidOperationException("Товар с указанным названием не найден.");
                productId = product.Id;
            }

            // Фильтруем поставки по поставщику и товару
            var deliveries = _repository.Data.Deliveries
                .Where(d => d.SupplierId == supplierId.Value && d.ProductId == productId.Value);

            // Фильтрация по периоду, если заданы даты
            if (startDate.HasValue)
                deliveries = deliveries.Where(d => d.Date >= startDate.Value);
            if (endDate.HasValue)
                deliveries = deliveries.Where(d => d.Date <= endDate.Value);

            // Формируем список результатов, добавляя для каждой поставки сведения о товаре и поставщике
            var resultList = deliveries.Select(d =>
            {
                var supplier = _repository.Data.Suppliers.FirstOrDefault(s => s.Id == d.SupplierId);
                var product = _repository.Data.Products.FirstOrDefault(p => p.Id == d.ProductId);
                return new Services.DeliveryRecord
                {
                    DeliveryId = d.Id,
                    SupplierName = supplier != null ? supplier.Name : "Неизвестный поставщик",
                    ProductName = product != null ? product.Name : "Неизвестный товар",
                    Date = d.Date,
                    Volume = d.Volume,
                    Price = d.Price
                };
            }).ToList();

            return new DeliveryQueryResult
            {
                Deliveries = resultList,
                TotalCount = resultList.Count
            };
        }
    }
}
