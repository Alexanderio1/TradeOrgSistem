using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class SellerSalaryQueryService
    {
        private readonly DataRepository _repository;

        public SellerSalaryQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public SellerSalaryQueryResult GetSellerSalaryData(string retailLocationType, int? retailLocationId, string retailLocationName)
        {
            var sellers = _repository.Data.Sellers.AsQueryable();

            if (retailLocationId.HasValue)
            {
                sellers = sellers.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location != null)
                {
                    sellers = sellers.Where(s => s.RetailLocationId == location.Id);
                }
                else
                {
                    return new SellerSalaryQueryResult
                    {
                        SellerSalaries = new List<SellerSalaryDetail>(),
                        TotalCount = 0
                    };
                }
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id)
                    .ToList();
                sellers = sellers.Where(s => locationIds.Contains(s.RetailLocationId));
            }

            var sellerList = sellers.ToList();

            var sellerSalaryDetails = sellerList.Select(s =>
            {
                var location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == s.RetailLocationId);
                return new SellerSalaryDetail
                {
                    SellerId = s.Id,
                    SellerName = s.Name,
                    Salary = s.Salary,
                    RetailLocationId = s.RetailLocationId,
                    RetailLocationName = location != null ? location.Name : "Неизвестная торговая точка"
                };
            }).ToList();

            return new SellerSalaryQueryResult
            {
                SellerSalaries = sellerSalaryDetails,
                TotalCount = sellerSalaryDetails.Count
            };
        }
    }
}
