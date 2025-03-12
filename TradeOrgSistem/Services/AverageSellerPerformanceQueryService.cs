using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class AverageSellerPerformanceQueryService
    {
        private readonly DataRepository _repository;

        public AverageSellerPerformanceQueryService()
        {
            _repository = DataRepository.Instance;
        }
        public AverageSellerPerformanceQueryResult GetAverageSellerPerformance(DateTime startDate, DateTime endDate, string retailLocationType)
        {
            var sales = _repository.Data.Sales.Where(s => s.Date >= startDate && s.Date <= endDate);

            if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }

            var sellerGroups = sales.GroupBy(s => s.SellerId);

            if (!sellerGroups.Any())
            {
                return new AverageSellerPerformanceQueryResult
                {
                    AverageSalesVolume = 0,
                    AverageRevenue = 0
                };
            }

            decimal averageVolume = sellerGroups.Average(g => (decimal)g.Sum(s => s.Volume));

            decimal averageRevenue = sellerGroups.Average(g => (decimal)g.Sum(s => s.Volume * s.Price));

            return new AverageSellerPerformanceQueryResult
            {
                AverageSalesVolume = averageVolume,
                AverageRevenue = averageRevenue
            };
        }
    }
}
