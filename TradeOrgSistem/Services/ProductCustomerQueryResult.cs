using System.Collections.Generic;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class ProductCustomerQueryResult
    {
        public List<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
}
