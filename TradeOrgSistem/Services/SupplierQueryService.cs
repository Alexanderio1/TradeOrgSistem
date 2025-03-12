using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class SupplierQueryService
    {
        private readonly DataRepository _repository;

        public SupplierQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public SupplierQueryResult GetSuppliersByProductCriteria(string productType, int? productId, string productName, int? minVolume, DateTime? startDate, DateTime? endDate)
        {
            var deliveries = _repository.Data.Deliveries.AsEnumerable();

            if (startDate.HasValue)
                deliveries = deliveries.Where(d => d.Date >= startDate.Value);
            if (endDate.HasValue)
                deliveries = deliveries.Where(d => d.Date <= endDate.Value);

            if (minVolume.HasValue)
                deliveries = deliveries.Where(d => d.Volume >= minVolume.Value);

            if (productId.HasValue)
            {
                deliveries = deliveries.Where(d => d.ProductId == productId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(productName))
            {
                deliveries = deliveries.Where(d =>
                    _repository.Data.Products.Any(p =>
                        p.Id == d.ProductId &&
                        p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)));
            }
            else if (!string.IsNullOrWhiteSpace(productType))
            {
                deliveries = deliveries.Where(d =>
                    _repository.Data.Products.Any(p =>
                        p.Id == d.ProductId &&
                        p.Type.Equals(productType, StringComparison.OrdinalIgnoreCase)));
            }

            var supplierIds = deliveries.Select(d => d.SupplierId).Distinct();

            var suppliers = _repository.Data.Suppliers.Where(s => supplierIds.Contains(s.Id)).ToList();

            return new SupplierQueryResult
            {
                Suppliers = suppliers,
                TotalCount = suppliers.Count
            };
        }
    }
}
