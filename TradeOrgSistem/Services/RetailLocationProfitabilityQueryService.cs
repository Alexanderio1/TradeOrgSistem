using System;
using System.Linq;
using TradeOrgSistem.Repository;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения данных о рентабельности торговой точки: 
    /// соотношение общей выручки от продаж к накладным расходам за указанный период.
    /// Накладные расходы рассчитываются как сумма:
    ///     (суммарная зарплата продавцов торговой точки + аренда + коммунальные платежи) * (продолжительность периода в месяцах).
    /// Фильтрация торговой точки может производиться по ID, по названию или по типу (приоритет: ID > название > тип).
    /// </summary>
    public class RetailLocationProfitabilityQueryService
    {
        private readonly DataRepository _repository;

        public RetailLocationProfitabilityQueryService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает данные о рентабельности торговой точки за указанный период.
        /// </summary>
        /// <param name="retailLocationId">
        /// ID торговой точки (если задан, используется для поиска).
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки (поиск без учета регистра, если ID не задан).
        /// </param>
        /// <param name="retailLocationType">
        /// Тип торговой точки, если ни ID, ни название не заданы (берется первая найденная точка данного типа).
        /// </param>
        /// <param name="startDate">Начало периода.</param>
        /// <param name="endDate">Конец периода.</param>
        /// <returns>
        /// Объект RetailLocationProfitabilityQueryResult с рассчитанными показателями:
        /// общая выручка, накладные расходы и соотношение выручки к накладным расходам.
        /// </returns>
        public RetailLocationProfitabilityQueryResult GetProfitability(
            int? retailLocationId, string retailLocationName, string retailLocationType,
            DateTime startDate, DateTime endDate)
        {
            // Определяем торговую точку
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

            // Получаем продажи для данной торговой точки за указанный период
            var sales = _repository.Data.Sales.Where(s => s.RetailLocationId == location.Id &&
                                                          s.Date >= startDate && s.Date <= endDate);
            // Рассчитываем общую выручку (объем продаж * цена)
            decimal totalSalesRevenue = sales.Sum(s => s.Volume * s.Price);

            // Получаем продавцов, работающих в данной торговой точке
            var sellers = _repository.Data.Sellers.Where(s => s.RetailLocationId == location.Id);
            // Суммарная зарплата продавцов (предполагается, что Salary – ежемесячная зарплата)
            decimal totalSellerSalaryMonthly = sellers.Sum(s => s.Salary);

            // Получаем арендную плату и коммунальные платежи (предполагается, что Rent и Utilities – ежемесячные значения)
            decimal monthlyRent = location.Rent;         // Это свойство должно быть добавлено в RetailLocation
            decimal monthlyUtilities = location.Utilities; // Это свойство должно быть добавлено в RetailLocation

            // Определяем длительность периода в месяцах (используем 30 дней за месяц как приближение)
            double totalDays = (endDate - startDate).TotalDays;
            decimal periodMonths = (decimal)(totalDays / 30.0);

            // Общие накладные расходы за период:
            // (суммарная зарплата продавцов + арендная плата + коммунальные платежи) * количество месяцев в периоде
            decimal overheadCosts = (totalSellerSalaryMonthly + monthlyRent + monthlyUtilities) * periodMonths;

            if (overheadCosts <= 0)
                throw new InvalidOperationException("Накладные расходы равны нулю или отрицательны, невозможно вычислить рентабельность.");

            // Вычисляем соотношение выручки к накладным расходам
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
