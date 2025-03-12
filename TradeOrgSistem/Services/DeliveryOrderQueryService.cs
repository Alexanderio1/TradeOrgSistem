using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class DeliveryOrderQueryService
    {
        private readonly DataRepository _repository;

        public DeliveryOrderQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public DeliveryOrderQueryResult GetDeliveriesByOrderNumber(string orderNumber)
        {
            if (string.IsNullOrWhiteSpace(orderNumber))
                throw new ArgumentException("Номер заказа не может быть пустым.", nameof(orderNumber));

            var deliveries = _repository.Data.Deliveries
                .Where(d => d.OrderNumber.Equals(orderNumber, StringComparison.OrdinalIgnoreCase));

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
