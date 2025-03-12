using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    public class SellerSalaryQueryResult
    {
        public List<SellerSalaryDetail> SellerSalaries { get; set; }

        public int TotalCount { get; set; }
    }

    public class SellerSalaryDetail
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public decimal Salary { get; set; }
        public int RetailLocationId { get; set; }
        public string RetailLocationName { get; set; }
    }
}
