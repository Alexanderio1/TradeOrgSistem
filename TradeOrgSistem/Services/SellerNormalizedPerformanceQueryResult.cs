using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    public enum NormalizationFactor
    {
        Area,
        Halls,
        Counters
    }


    public class SellerNormalizedPerformanceQueryResult
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
        public int TotalSalesVolume { get; set; }
        public NormalizationFactor NormalizationType { get; set; }
        public decimal NormalizationValue { get; set; }
        public decimal Ratio { get; set; }
    }
}
