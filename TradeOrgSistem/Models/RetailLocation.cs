using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class RetailLocation : IRetailLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<IInventoryItem> Inventory { get; set; }
    }
}
