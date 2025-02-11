using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения сведений о поставках товаров по указанному номеру заказа.
    /// Предполагается, что в модели поставки (Delivery) имеется свойство OrderNumber.
    /// </summary>
    public class DeliveryOrderQueryService
    {
        private readonly DataRepository _repository;

        public DeliveryOrderQueryService()
        {
            // Используем Singleton-экземпляр для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает сведения о поставках товаров, соответствующих указанному номеру заказа.
        /// Поиск производится без учёта регистра.
        /// </summary>
        /// <param name="orderNumber">Номер заказа, по которому производится поиск поставок.</param>
        /// <returns>
        /// Объект DeliveryOrderQueryResult, содержащий список поставок с деталями и общее число найденных записей.
        /// </returns>
        public DeliveryOrderQueryResult GetDeliveriesByOrderNumber(string orderNumber)
        {
            if (string.IsNullOrWhiteSpace(orderNumber))
                throw new ArgumentException("Номер заказа не может быть пустым.", nameof(orderNumber));

            // Фильтруем поставки по номеру заказа (без учёта регистра)
            var deliveries = _repository.Data.Deliveries
                .Where(d => d.OrderNumber.Equals(orderNumber, StringComparison.OrdinalIgnoreCase));

            // Формируем список результатов с дополнительными сведениями для удобства пользователя
            var resultList = deliveries.Select(d =>
            {
                var supplier = _repository.Data.Suppliers.FirstOrDefault(s => s.Id == d.SupplierId);
                var product = _repository.Data.Products.FirstOrDefault(p => p.Id == d.ProductId);
                return new DeliveryOrderRecord
                {
                    DeliveryId = d.Id,
                    OrderNumber = d.OrderNumber,
                    SupplierName = supplier != null ? supplier.Name : "Неизвестный поставщик",
                    ProductName = product != null ? product.Name : "Неизвестный товар",
                    Date = d.Date,
                    Volume = d.Volume,
                    Price = d.Price
                };
            }).ToList();

            return new DeliveryOrderQueryResult
            {
                Deliveries = resultList,
                TotalCount = resultList.Count
            };
        }
    }
}
