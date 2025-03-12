using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    public class IndividualSellerPerformanceQueryResult
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
        public int TotalSalesVolume { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
