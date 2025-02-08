using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public interface IDataRoot
    {
        List<ISupplier> Suppliers { get; set; }
        List<ICustomer> Customers { get; set; }
        List<IProduct> Products { get; set; }
        List<IDelivery> Deliveries { get; set; }
        List<IRetailLocation> RetailLocations { get; set; }
        List<ISale> Sales { get; set; }
        List<ISeller> Sellers { get; set; }
    }
}
