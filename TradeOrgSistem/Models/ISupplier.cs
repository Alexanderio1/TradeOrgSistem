using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public interface ISupplier
    {
        int Id { get; set; }
        string Name { get; set; }
        List<int> Products { get; set; }
    }
}
