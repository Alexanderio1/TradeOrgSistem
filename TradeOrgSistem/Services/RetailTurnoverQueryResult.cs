using System.Collections.Generic;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Детали товарооборота для отдельной торговой точки.
    /// </summary>
    public class RetailTurnoverRecord
    {
        /// <summary>
        /// ID торговой точки.
        /// </summary>
        public int RetailLocationId { get; set; }
        /// <summary>
        /// Название торговой точки.
        /// </summary>
        public string RetailLocationName { get; set; }
        /// <summary>
        /// Суммарная выручка от продаж в данной торговой точке за заданный период.
        /// </summary>
        public decimal SalesRevenue { get; set; }
        /// <summary>
        /// Общий объём продаж (количество проданных единиц) в данной торговой точке.
        /// </summary>
        public int SalesVolume { get; set; }
    }

    /// <summary>
    /// Результат запроса товарооборота.
    /// </summary>
    public class RetailTurnoverQueryResult
    {
        /// <summary>
        /// Общая выручка от продаж по всем выбранным торговым точкам за заданный период.
        /// </summary>
        public decimal TotalSalesRevenue { get; set; }
        /// <summary>
        /// Общий объём продаж (количество проданных единиц) по всем выбранным торговым точкам за заданный период.
        /// </summary>
        public int TotalSalesVolume { get; set; }
        /// <summary>
        /// Подробная разбивка по каждой торговой точке.
        /// </summary>
        public List<RetailTurnoverRecord> Breakdown { get; set; }
    }
}
