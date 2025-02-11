using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса по средней выработке продавца (на одного продавца).
    /// </summary>
    public class AverageSellerPerformanceQueryResult
    {
        /// <summary>
        /// Средний объём продаж (сумма объёмов продаж, делённая на число продавцов, совершивших продажи).
        /// </summary>
        public decimal AverageSalesVolume { get; set; }

        /// <summary>
        /// Средняя выручка (сумма выручки, делённая на число продавцов, совершивших продажи).
        /// </summary>
        public decimal AverageRevenue { get; set; }
    }
}
