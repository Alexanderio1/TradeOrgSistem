using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Seller : ISeller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RetailLocationId { get; set; }
        public decimal Salary { get; set; }
    }
}
