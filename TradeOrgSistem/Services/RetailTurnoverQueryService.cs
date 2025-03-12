using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class RetailTurnoverQueryService
    {
        private readonly DataRepository _repository;

        public RetailTurnoverQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public RetailTurnoverQueryResult GetRetailTurnover(
            DateTime startDate,
            DateTime endDate,
            int? retailLocationId,
            string retailLocationName,
            string retailLocationType)
        {
            IEnumerable<IRetailLocation> locations = _repository.Data.RetailLocations;

            if (retailLocationId.HasValue)
            {
                locations = locations.Where(r => r.Id == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                locations = locations.Where(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                locations = locations.Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase));
            }
            var locationIds = locations.Select(r => r.Id).ToList();

            var sales = _repository.Data.Sales
                .Where(s => s.Date >= startDate && s.Date <= endDate && locationIds.Contains(s.RetailLocationId));

            var breakdown = sales.GroupBy(s => s.RetailLocationId)
                .Select(g =>
                {
                    var location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == g.Key);
                    return new RetailTurnoverRecord
                    {
                        RetailLocationId = g.Key,
                        RetailLocationName = location != null ? location.Name : "Неизвестная точка",
                        SalesRevenue = g.Sum(s => s.Volume * s.Price),
                        SalesVolume = g.Sum(s => s.Volume)
                    };
                })
                .ToList();

            decimal totalRevenue = breakdown.Sum(r => r.SalesRevenue);
            int totalVolume = breakdown.Sum(r => r.SalesVolume);

            return new RetailTurnoverQueryResult
            {
                TotalSalesRevenue = totalRevenue,
                TotalSalesVolume = totalVolume,
                Breakdown = breakdown
            };
        }
    }
}
