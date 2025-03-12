using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models; 

namespace TradeOrgSistem.Services
{
    public class SellerNormalizedPerformanceQueryService
    {
        private readonly DataRepository _repository;

        public SellerNormalizedPerformanceQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public SellerNormalizedPerformanceQueryResult GetNormalizedPerformance(
            int? sellerId, string sellerName,
            int? retailLocationId, string retailLocationName,
            DateTime startDate, DateTime endDate,
            NormalizationFactor normalizationFactor)
        {
            if (!sellerId.HasValue)
            {
                if (string.IsNullOrWhiteSpace(sellerName))
                    throw new ArgumentException("Необходимо указать либо ID продавца, либо его имя.", nameof(sellerName));

                var sellerRecord = _repository.Data.Sellers
                    .FirstOrDefault(s => s.Name.Equals(sellerName, StringComparison.OrdinalIgnoreCase));
                if (sellerRecord == null)
                    throw new InvalidOperationException("Продавец с указанным именем не найден.");
                sellerId = sellerRecord.Id;
            }
            var seller = _repository.Data.Sellers.FirstOrDefault(s => s.Id == sellerId.Value);
            if (seller == null)
                throw new InvalidOperationException("Продавец не найден.");

            IRetailLocation retailLocation = null;
            if (retailLocationId.HasValue)
            {
                retailLocation = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                retailLocation = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
            }
            if (retailLocation == null)
                throw new InvalidOperationException("Торговая точка не найдена.");

            var sales = _repository.Data.Sales.Where(s =>
                s.SellerId == seller.Id &&
                s.RetailLocationId == retailLocation.Id &&
                s.Date >= startDate &&
                s.Date <= endDate);

            int totalSalesVolume = sales.Sum(s => s.Volume);

            decimal normalizationValue = 0;
            switch (normalizationFactor)
            {
                case NormalizationFactor.Area:
                    normalizationValue = retailLocation.Area;
                    break;
                case NormalizationFactor.Halls:
                    normalizationValue = retailLocation.NumberOfHalls;
                    break;
                case NormalizationFactor.Counters:
                    normalizationValue = retailLocation.NumberOfCounters;
                    break;
                default:
                    throw new ArgumentException("Неизвестный тип нормализации.", nameof(normalizationFactor));
            }

            if (normalizationValue <= 0)
                throw new InvalidOperationException("Значение нормализационного показателя должно быть положительным.");

            decimal ratio = totalSalesVolume / normalizationValue;

            return new SellerNormalizedPerformanceQueryResult
            {
                SellerId = seller.Id,
                SellerName = seller.Name,
                RetailLocationId = retailLocation.Id,
                RetailLocationName = retailLocation.Name,
                TotalSalesVolume = totalSalesVolume,
                NormalizationType = normalizationFactor,
                NormalizationValue = normalizationValue,
                Ratio = ratio
            };
        }
    }
}
