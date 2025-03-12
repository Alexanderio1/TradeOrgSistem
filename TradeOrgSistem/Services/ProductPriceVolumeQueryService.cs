using System;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class ProductPriceVolumeQueryService
    {
        private readonly DataRepository _repository;

        public ProductPriceVolumeQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public ProductPriceVolumeQueryResult GetProductPriceVolumeInfo(int? productId, string productName, string retailLocationType, int? retailLocationId, string retailLocationName)
        {
            if (!productId.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(productName))
                {
                    var product = _repository.Data.Products
                        .FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
                    if (product == null)
                        throw new InvalidOperationException("Товар с указанным именем не найден.");
                    productId = product.Id;
                }
                else
                {
                    throw new InvalidOperationException("Необходимо указать либо Product ID, либо Product Name.");
                }
            }

            var sales = _repository.Data.Sales.Where(s => s.ProductId == productId.Value);

            if (retailLocationId.HasValue)
            {
                sales = sales.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location == null)
                {
                    return new ProductPriceVolumeQueryResult
                    {
                        ProductId = productId.Value,
                        TotalVolume = 0,
                        MinPrice = 0,
                        MaxPrice = 0,
                        AveragePrice = 0
                    };
                }
                sales = sales.Where(s => s.RetailLocationId == location.Id);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }

            if (!sales.Any())
            {
                return new ProductPriceVolumeQueryResult
                {
                    ProductId = productId.Value,
                    TotalVolume = 0,
                    MinPrice = 0,
                    MaxPrice = 0,
                    AveragePrice = 0
                };
            }

            int totalVolume = sales.Sum(s => s.Volume);
            decimal minPrice = sales.Min(s => s.Price);
            decimal maxPrice = sales.Max(s => s.Price);
            decimal avgPrice = sales.Average(s => s.Price);

            return new ProductPriceVolumeQueryResult
            {
                ProductId = productId.Value,
                TotalVolume = totalVolume,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                AveragePrice = avgPrice
            };
        }
    }
}
