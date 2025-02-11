using System.Collections.Generic;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Детали активности покупателя.
    /// </summary>
    public class ActiveCustomerRecord
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        /// <summary>
        /// Суммарный объём покупок (количество проданных единиц) данного покупателя.
        /// </summary>
        public int TotalSalesVolume { get; set; }
        /// <summary>
        /// Общая выручка покупок данного покупателя.
        /// </summary>
        public decimal TotalSalesRevenue { get; set; }
        /// <summary>
        /// Количество совершённых транзакций.
        /// </summary>
        public int NumberOfTransactions { get; set; }
    }

    /// <summary>
    /// Результат запроса по наиболее активным покупателям.
    /// </summary>
    public class ActiveCustomerQueryResult
    {
        public List<ActiveCustomerRecord> ActiveCustomers { get; set; }
        public int TotalCount { get; set; }
    }
}
