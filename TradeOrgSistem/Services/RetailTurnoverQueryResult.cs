using System.Collections.Generic;

namespace TradeOrgSistem.Services
{
    public class RetailTurnoverRecord
    {
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
        public decimal SalesRevenue { get; set; }
        public int SalesVolume { get; set; }
    }

    public class RetailTurnoverQueryResult
    {
        public decimal TotalSalesRevenue { get; set; }
        public int TotalSalesVolume { get; set; }
        public List<RetailTurnoverRecord> Breakdown { get; set; }
    }
}
