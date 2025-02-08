using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public interface IInventoryItem
    {
        int ProductId { get; set; }
        int Volume { get; set; }
    }
}
