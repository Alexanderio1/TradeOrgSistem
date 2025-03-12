using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{

    public class ProductCustomerQueryService
    {
        private readonly DataRepository _repository;

        public ProductCustomerQueryService()
        {
            _repository = DataRepository.Instance;
        }

        
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
            
            var sales = _repository.Data.Sales.AsEnumerable();

            
            if (startDate.HasValue)
                sales = sales.Where(s => s.Date >= startDate.Value);
            if (endDate.HasValue)
                sales = sales.Where(s => s.Date <= endDate.Value);

            
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
            
            var customerIds = sales.Select(s => s.CustomerId).Distinct();

            
            var customers = _repository.Data.Customers.Where(c => customerIds.Contains(c.Id)).ToList();

            return new ProductCustomerQueryResult
            {
                Customers = customers,
                TotalCount = customers.Count
            };
        }
    }
}
