using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class ActiveCustomerQueryService
    {
        private readonly DataRepository _repository;

        public ActiveCustomerQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public ActiveCustomerQueryResult GetActiveCustomers(
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

            if (retailLocationId.HasValue)
            {
                sales = sales.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location != null)
                    sales = sales.Where(s => s.RetailLocationId == location.Id);
                else
                    sales = Enumerable.Empty<Sale>();
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }

            var customerGroups = sales.GroupBy(s => s.CustomerId);

            var activeCustomerRecords = customerGroups.Select(g =>
            {
                int totalVolume = g.Sum(s => s.Volume);
                decimal totalRevenue = g.Sum(s => s.Volume * s.Price);
                int numberOfTransactions = g.Count();

                var customer = _repository.Data.Customers.FirstOrDefault(c => c.Id == g.Key);
                string customerName = customer != null ? customer.Name : "Неизвестный покупатель";

                return new ActiveCustomerRecord
                {
                    CustomerId = g.Key,
                    CustomerName = customerName,
                    TotalSalesVolume = totalVolume,
                    TotalSalesRevenue = totalRevenue,
                    NumberOfTransactions = numberOfTransactions
                };
            })
            // сортировка по убыванию суммарного объёма покупок (показатель активности)
            .OrderByDescending(r => r.TotalSalesVolume)
            .ToList();

            return new ActiveCustomerQueryResult
            {
                ActiveCustomers = activeCustomerRecords,
                TotalCount = activeCustomerRecords.Count
            };
        }
    }
}
