using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class ProductSalesVolumeQueryService
    {
        private readonly DataRepository _repository;

        public ProductSalesVolumeQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public ProductSalesVolumeQueryResult GetProductSalesVolume(
            int productId,
            DateTime startDate,
            DateTime endDate,
            string retailLocationType,
            int? retailLocationId,
            string retailLocationName)
        {
            var sales = _repository.Data.Sales
                .Where(s => s.ProductId == productId && s.Date >= startDate && s.Date <= endDate);

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
                    return new ProductSalesVolumeQueryResult
                    {
                        ProductId = productId,
                        ProductName = _repository.Data.Products.FirstOrDefault(p => p.Id == productId)?.Name ?? "Неизвестный товар",
                        TotalSalesVolume = 0
                    };
                }
            }

            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }

            int totalVolume = sales.Sum(s => s.Volume);


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
