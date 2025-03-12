using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    public class RetailLocationProfitabilityQueryResult
    {
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
        public decimal TotalSalesRevenue { get; set; }
        public decimal OverheadCosts { get; set; }
        public decimal ProfitabilityRatio { get; set; }
    }
}
