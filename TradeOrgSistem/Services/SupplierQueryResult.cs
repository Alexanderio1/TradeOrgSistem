using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    public class SupplierQueryResult
    {
        public List<Supplier> Suppliers { get; set; }
        public int TotalCount { get; set; }
    }
}
