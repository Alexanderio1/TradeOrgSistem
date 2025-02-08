using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class DataRoot : IDataRoot
    {
        public List<ISupplier> Suppliers { get; set; }
        public List<ICustomer> Customers { get; set; }
        public List<IProduct> Products { get; set; }
        public List<IDelivery> Deliveries { get; set; }
        public List<IRetailLocation> RetailLocations { get; set; }
        public List<ISale> Sales { get; set; }
        public List<ISeller> Sellers { get; set; }
    }
}
