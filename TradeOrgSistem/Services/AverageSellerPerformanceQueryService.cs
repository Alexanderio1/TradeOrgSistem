using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения данных о выработке на одного продавца за указанный период.
    /// Расчёт производится по всем продажам (или по продажам торговых точек заданного типа),
    /// после чего определяется средняя выработка (объём и выручка) среди продавцов, совершивших продажи.
    /// </summary>
    public class AverageSellerPerformanceQueryService
    {
        private readonly DataRepository _repository;

        public AverageSellerPerformanceQueryService()
        {
            // Используем Singleton-экземпляр для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Вычисляет среднюю выработку на одного продавца за указанный период.
        /// Если задан retailLocationType, учитываются только продажи в торговых точках этого типа.
        /// Если фильтр по торговым точкам не задан, используются продажи по всем торговым точкам.
        /// Если ни один продавец не совершил продаж за указанный период, возвращаются нулевые значения.
        /// </summary>
        /// <param name="startDate">Начало анализируемого периода.</param>
        /// <param name="endDate">Конец анализируемого периода.</param>
        /// <param name="retailLocationType">
        /// Тип торговой точки для фильтрации (опционально). Если задан, учитываются продажи только в торговых точках этого типа.
        /// </param>
        /// <returns>
        /// Объект AverageSellerPerformanceQueryResult с рассчитанными средними значениями объёма продаж и выручки на одного продавца.
        /// </returns>
        public AverageSellerPerformanceQueryResult GetAverageSellerPerformance(DateTime startDate, DateTime endDate, string retailLocationType)
        {
            // Получаем продажи за указанный период
            var sales = _repository.Data.Sales.Where(s => s.Date >= startDate && s.Date <= endDate);

            // Если задан тип торговой точки, дополнительно фильтруем продажи по этому критерию
            if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }

            // Группируем продажи по продавцам (т.е. по SellerId) – считаем, какие продавцы совершили продажи
            var sellerGroups = sales.GroupBy(s => s.SellerId);

            // Если ни один продавец не совершил продаж, возвращаем нулевые показатели
            if (!sellerGroups.Any())
            {
                return new AverageSellerPerformanceQueryResult
                {
                    AverageSalesVolume = 0,
                    AverageRevenue = 0
                };
            }

            // Вычисляем средний объём продаж на одного продавца с явным приведением к decimal
            decimal averageVolume = sellerGroups.Average(g => (decimal)g.Sum(s => s.Volume));

            // Вычисляем среднюю выручку на одного продавца (сумма произведений объёма и цены) с явным приведением к decimal
            decimal averageRevenue = sellerGroups.Average(g => (decimal)g.Sum(s => s.Volume * s.Price));

            return new AverageSellerPerformanceQueryResult
            {
                AverageSalesVolume = averageVolume,
                AverageRevenue = averageRevenue
            };
        }
    }
}
