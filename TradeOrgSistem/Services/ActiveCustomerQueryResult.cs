using System.Collections.Generic;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class ActiveCustomerRecord
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int TotalSalesVolume { get; set; }
        public decimal TotalSalesRevenue { get; set; }
        public int NumberOfTransactions { get; set; }
    }

    public class ActiveCustomerQueryResult
    {
        public List<ActiveCustomerRecord> ActiveCustomers { get; set; }
        public int TotalCount { get; set; }
    }
}
