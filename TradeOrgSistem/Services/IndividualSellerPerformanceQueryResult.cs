using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса выработки для конкретного продавца в конкретной торговой точке.
    /// </summary>
    public class IndividualSellerPerformanceQueryResult
    {
        /// <summary>
        /// ID продавца.
        /// </summary>
        public int SellerId { get; set; }
        /// <summary>
        /// Имя продавца.
        /// </summary>
        public string SellerName { get; set; }
        /// <summary>
        /// ID торговой точки.
        /// </summary>
        public int RetailLocationId { get; set; }
        /// <summary>
        /// Название торговой точки.
        /// </summary>
        public string RetailLocationName { get; set; }
        /// <summary>
        /// Общий объём продаж (например, количество проданных единиц).
        /// </summary>
        public int TotalSalesVolume { get; set; }
        /// <summary>
        /// Общая выручка от продаж.
        /// </summary>
        public decimal TotalRevenue { get; set; }
    }
}
