using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class InventoryItem : IInventoryItem
    {
        public int ProductId { get; set; }
        public int Volume { get; set; }
    }
}
