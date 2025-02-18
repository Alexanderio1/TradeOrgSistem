using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    //результат запроса на перечень поставщиков и их общее число
    public class SupplierQueryResult
    {
        public List<Supplier> Suppliers { get; set; }
        public int TotalCount { get; set; }
    }
}
