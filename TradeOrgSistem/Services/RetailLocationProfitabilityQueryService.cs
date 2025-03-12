using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class RetailLocationProfitabilityQueryService
    {
        private readonly DataRepository _repository;

        public RetailLocationProfitabilityQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public RetailLocationProfitabilityQueryResult GetProfitability(
            int? retailLocationId, string retailLocationName, string retailLocationType,
            DateTime startDate, DateTime endDate)
        {
            IRetailLocation location = null;
            if (retailLocationId.HasValue)
            {
                location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase));
            }

            if (location == null)
                throw new InvalidOperationException("Торговая точка не найдена по заданным параметрам.");

            var sales = _repository.Data.Sales.Where(s => s.RetailLocationId == location.Id &&
                                                          s.Date >= startDate && s.Date <= endDate);
            decimal totalSalesRevenue = sales.Sum(s => s.Volume * s.Price);

            var sellers = _repository.Data.Sellers.Where(s => s.RetailLocationId == location.Id);
            decimal totalSellerSalaryMonthly = sellers.Sum(s => s.Salary);

            decimal monthlyRent = location.Rent;
            decimal monthlyUtilities = location.Utilities;

            double totalDays = (endDate - startDate).TotalDays;
            decimal periodMonths = (decimal)(totalDays / 30.0);
            decimal overheadCosts = (totalSellerSalaryMonthly + monthlyRent + monthlyUtilities) * periodMonths;

            if (overheadCosts <= 0)
                throw new InvalidOperationException("Накладные расходы равны нулю или отрицательны, невозможно вычислить рентабельность.");

            decimal profitabilityRatio = totalSalesRevenue / overheadCosts;

            return new RetailLocationProfitabilityQueryResult
            {
                RetailLocationId = location.Id,
                RetailLocationName = location.Name,
                TotalSalesRevenue = totalSalesRevenue,
                OverheadCosts = overheadCosts,
                ProfitabilityRatio = profitabilityRatio
            };
        }
    }
}
