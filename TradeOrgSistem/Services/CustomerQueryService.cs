using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class CustomerQueryService
    {
        private readonly DataRepository _repository;

        public CustomerQueryService()
        {
            _repository = DataRepository.Instance;
        }

        
        public CustomerQueryResult GetCustomersByProductCriteria(string productType, int? productId, string productName, int? minVolume, DateTime? startDate, DateTime? endDate)
        {
            var sales = _repository.Data.Sales.AsEnumerable();

            if (startDate.HasValue)
                sales = sales.Where(s => s.Date >= startDate.Value);
            if (endDate.HasValue)
                sales = sales.Where(s => s.Date <= endDate.Value);


            if (minVolume.HasValue)
                sales = sales.Where(s => s.Volume >= minVolume.Value);

            if (productId.HasValue)
            {
                sales = sales.Where(s => s.ProductId == productId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(productName))
            {
                sales = sales.Where(s =>
                    _repository.Data.Products.Any(p =>
                        p.Id == s.ProductId &&
                        p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)));
            }
            else if (!string.IsNullOrWhiteSpace(productType))
            {
                sales = sales.Where(s =>
                    _repository.Data.Products.Any(p =>
                        p.Id == s.ProductId &&
                        p.Type.Equals(productType, StringComparison.OrdinalIgnoreCase)));
            }

            var customerIds = sales.Select(s => s.CustomerId).Distinct();

            var customers = _repository.Data.Customers.Where(c => customerIds.Contains(c.Id)).ToList();

            return new CustomerQueryResult
            {
                Customers = customers,
                TotalCount = customers.Count
            };
        }
    }
}
