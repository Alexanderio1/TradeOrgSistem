using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса покупателей: перечень покупателей и их общее число.
    /// </summary>
    public class CustomerQueryResult
    {
        public List<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
}
