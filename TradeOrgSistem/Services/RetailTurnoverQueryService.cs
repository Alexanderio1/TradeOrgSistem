using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения данных о товарообороте (выручке и объёме продаж) за указанный период.
    /// Фильтрация торговых точек может выполняться по ID, по названию или по типу.
    /// </summary>
    public class RetailTurnoverQueryService
    {
        private readonly DataRepository _repository;

        public RetailTurnoverQueryService()
        {
            // Используем Singleton-экземпляр для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает данные о товарообороте для торговой точки или группы торговых точек за заданный период.
        /// Если retailLocationId задан, используется он; если нет, но задан retailLocationName – поиск по названию;
        /// если и его нет, но задан retailLocationType – используются торговые точки этого типа.
        /// Если ни один параметр не задан, данные рассчитываются по всем торговым точкам.
        /// </summary>
        /// <param name="startDate">Начало анализируемого периода.</param>
        /// <param name="endDate">Конец анализируемого периода.</param>
        /// <param name="retailLocationId">
        /// ID торговой точки (если задан, используется для фильтрации).
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки (используется, если ID не задан).
        /// </param>
        /// <param name="retailLocationType">
        /// Тип торговой точки (используется, если не заданы ни ID, ни название).
        /// </param>
        /// <returns>
        /// Объект RetailTurnoverQueryResult, содержащий общую выручку, общий объём продаж и подробную разбивку по торговым точкам.
        /// </returns>
        public RetailTurnoverQueryResult GetRetailTurnover(
            DateTime startDate,
            DateTime endDate,
            int? retailLocationId,
            string retailLocationName,
            string retailLocationType)
        {
            // Получаем торговые точки с учетом фильтрации.
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
            // Если ни один фильтр не задан, locations остаются всеми торговыми точками.

            // Получаем список ID отобранных торговых точек.
            var locationIds = locations.Select(r => r.Id).ToList();

            // Фильтруем продажи по периоду и по выбранным торговым точкам.
            var sales = _repository.Data.Sales
                .Where(s => s.Date >= startDate && s.Date <= endDate && locationIds.Contains(s.RetailLocationId));

            // Группируем продажи по торговой точке для формирования разбивки.
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
