using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения данных о выработке отдельно взятого продавца в отдельно взятой торговой точке за указанный период.
    /// Позволяет задавать продавца и торговую точку либо по ID, либо по имени для удобства пользователя.
    /// </summary>
    public class IndividualSellerPerformanceQueryService
    {
        private readonly DataRepository _repository;

        public IndividualSellerPerformanceQueryService()
        {
            // Используем Singleton-экземпляр для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает агрегированные данные о выработке для конкретного продавца в конкретной торговой точке за заданный период.
        /// Если sellerId не задан, производится поиск по sellerName (без учета регистра).
        /// Аналогично, если retailLocationId не задан, ищется торговая точка по retailLocationName.
        /// Требуется, чтобы хотя бы продавец и торговая точка были определены.
        /// </summary>
        /// <param name="sellerId">
        /// ID продавца. Если задан, используется; если нет, то ищется продавец по sellerName.
        /// </param>
        /// <param name="sellerName">
        /// Имя продавца (используется, если sellerId не задан). Поиск производится без учета регистра.
        /// </param>
        /// <param name="retailLocationId">
        /// ID торговой точки. Если задан, используется; если нет, то ищется торговая точка по retailLocationName.
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки (используется, если retailLocationId не задан). Поиск производится без учета регистра.
        /// </param>
        /// <param name="startDate">Начало анализируемого периода.</param>
        /// <param name="endDate">Конец анализируемого периода.</param>
        /// <returns>
        /// Объект IndividualSellerPerformanceQueryResult с агрегированными данными: общий объём продаж и выручка.
        /// </returns>
        public IndividualSellerPerformanceQueryResult GetPerformanceForSellerAtLocation(
            int? sellerId, string sellerName,
            int? retailLocationId, string retailLocationName,
            DateTime startDate, DateTime endDate)
        {
            // Определяем продавца:
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

            // Определяем торговую точку:
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

            // Фильтруем продажи по продавцу, торговой точке и заданному периоду
            var sales = _repository.Data.Sales.Where(s =>
                s.SellerId == sellerId.Value &&
                s.RetailLocationId == retailLocationId.Value &&
                s.Date >= startDate &&
                s.Date <= endDate);

            int totalVolume = sales.Sum(s => s.Volume);
            decimal totalRevenue = sales.Sum(s => s.Volume * s.Price);

            // Получаем имя продавца (если необходимо)
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
