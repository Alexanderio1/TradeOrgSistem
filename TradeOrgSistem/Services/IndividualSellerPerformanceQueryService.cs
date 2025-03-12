using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class IndividualSellerPerformanceQueryService
    {
        private readonly DataRepository _repository;

        public IndividualSellerPerformanceQueryService()
        {
            _repository = DataRepository.Instance;
        }

        
        public IndividualSellerPerformanceQueryResult GetPerformanceForSellerAtLocation(
            int? sellerId, string sellerName,
            int? retailLocationId, string retailLocationName,
            DateTime startDate, DateTime endDate)
        {
            if (!sellerId.HasValue)
            {
                if (string.IsNullOrWhiteSpace(sellerName))
                    throw new ArgumentException("Необходимо указать либо ID продавца, либо его имя.", nameof(sellerName));

                var sellerFromName = _repository.Data.Sellers
                    .FirstOrDefault(s => s.Name.Equals(sellerName, StringComparison.OrdinalIgnoreCase));
                if (sellerFromName == null)
                    throw new InvalidOperationException("Продавец с указанным именем не найден.");

                sellerId = sellerFromName.Id;
            }

            Models.IRetailLocation retailLocation = null;
            if (retailLocationId.HasValue)
            {
                retailLocation = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Id == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                retailLocation = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
            }
            if (retailLocation == null)
            {
                throw new InvalidOperationException("Торговая точка не найдена. Проверьте введенные данные.");
            }
            retailLocationId = retailLocation.Id;

            var sales = _repository.Data.Sales.Where(s =>
                s.SellerId == sellerId.Value &&
                s.RetailLocationId == retailLocationId.Value &&
                s.Date >= startDate &&
                s.Date <= endDate);

            int totalVolume = sales.Sum(s => s.Volume);
            decimal totalRevenue = sales.Sum(s => s.Volume * s.Price);

            var sellerRecord = _repository.Data.Sellers.FirstOrDefault(s => s.Id == sellerId.Value);
            string resolvedSellerName = sellerRecord != null ? sellerRecord.Name : "Неизвестный продавец";

            return new IndividualSellerPerformanceQueryResult
            {
                SellerId = sellerId.Value,
                SellerName = resolvedSellerName,
                RetailLocationId = retailLocation.Id,
                RetailLocationName = retailLocation.Name,
                TotalSalesVolume = totalVolume,
                TotalRevenue = totalRevenue
            };
        }
    }
}
