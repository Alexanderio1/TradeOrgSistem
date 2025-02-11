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
        IReadOnlyList<int> ProductIds { get; }
        void AttachProduct(IProduct product);
        void DetachProduct(IProduct product);
    }
}
