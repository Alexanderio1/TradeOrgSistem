using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models; 

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения нормализованной выработки продавца в торговой точке за указанный период.
    /// Нормализация производится по торговой площади, числу торговых залов или числу прилавков.
    /// Продавца и торговую точку можно задавать либо по ID, либо по имени (без учёта регистра).
    /// </summary>
    public class SellerNormalizedPerformanceQueryService
    {
        private readonly DataRepository _repository;

        public SellerNormalizedPerformanceQueryService()
        {
            // Используем Singleton-экземпляр для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает нормализованную выработку для конкретного продавца в конкретной торговой точке за заданный период.
        /// Если sellerId не задан, производится поиск по sellerName. Аналогично для торговой точки.
        /// Нормализация производится по выбранному параметру (Area, Halls или Counters).
        /// </summary>
        /// <param name="sellerId">
        /// ID продавца (если известен). Если не задан, используется sellerName.
        /// </param>
        /// <param name="sellerName">
        /// Имя продавца (используется, если sellerId не задан). Поиск без учёта регистра.
        /// </param>
        /// <param name="retailLocationId">
        /// ID торговой точки (если известен). Если не задан, используется retailLocationName.
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки (используется, если retailLocationId не задан). Поиск без учёта регистра.
        /// </param>
        /// <param name="startDate">Начало анализируемого периода.</param>
        /// <param name="endDate">Конец анализируемого периода.</param>
        /// <param name="normalizationFactor">
        /// Тип нормализации: Area, Halls или Counters.
        /// </param>
        /// <returns>
        /// Объект SellerNormalizedPerformanceQueryResult с агрегированными данными.
        /// </returns>
        public SellerNormalizedPerformanceQueryResult GetNormalizedPerformance(
            int? sellerId, string sellerName,
            int? retailLocationId, string retailLocationName,
            DateTime startDate, DateTime endDate,
            NormalizationFactor normalizationFactor)
        {
            // Определяем продавца:
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

            // Определяем торговую точку:
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

            // Фильтруем продажи по продавцу, торговой точке и заданному периоду
            var sales = _repository.Data.Sales.Where(s =>
                s.SellerId == seller.Id &&
                s.RetailLocationId == retailLocation.Id &&
                s.Date >= startDate &&
                s.Date <= endDate);

            int totalSalesVolume = sales.Sum(s => s.Volume);

            // Получаем значение нормализации из торговой точки в зависимости от выбранного параметра.
            // Предполагается, что RetailLocation содержит свойства: Area (decimal), NumberOfHalls (int) и NumberOfCounters (int).
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
