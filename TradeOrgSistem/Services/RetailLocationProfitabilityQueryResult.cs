using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса по рентабельности торговой точки.
    /// </summary>
    public class RetailLocationProfitabilityQueryResult
    {
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
        /// <summary>
        /// Общая выручка от продаж (сумма произведений объёма на цену) за указанный период.
        /// </summary>
        public decimal TotalSalesRevenue { get; set; }
        /// <summary>
        /// Расчетные накладные расходы за период.
        /// </summary>
        public decimal OverheadCosts { get; set; }
        /// <summary>
        /// Соотношение выручки к накладным расходам.
        /// </summary>
        public decimal ProfitabilityRatio { get; set; }
    }
}
