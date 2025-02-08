using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Supplier : ISupplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Products { get; set; }
    }
}
