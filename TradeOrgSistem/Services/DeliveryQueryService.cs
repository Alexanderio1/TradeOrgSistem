using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;  
namespace TradeOrgSistem.Services
{
    public class DeliveryQueryService
    {
        private readonly DataRepository _repository;

        public DeliveryQueryService()
        {
            _repository = DataRepository.Instance;
        }

        
        public DeliveryQueryResult GetDeliveriesForSupplierAndProduct(
            int? supplierId, string supplierName,
            int? productId, string productName,
            DateTime? startDate, DateTime? endDate)
        {
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

            var deliveries = _repository.Data.Deliveries
                .Where(d => d.SupplierId == supplierId.Value && d.ProductId == productId.Value);

            if (startDate.HasValue)
                deliveries = deliveries.Where(d => d.Date >= startDate.Value);
            if (endDate.HasValue)
                deliveries = deliveries.Where(d => d.Date <= endDate.Value);

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
