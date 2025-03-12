using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class CustomerQueryResult
    {
        public List<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
}
