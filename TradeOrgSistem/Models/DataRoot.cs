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

        public DataRoot()
        {
            Suppliers = new List<ISupplier>();
            Customers = new List<ICustomer>();
            Products = new List<IProduct>();
            Deliveries = new List<IDelivery>();
            RetailLocations = new List<IRetailLocation>();
            Sales = new List<ISale>();
            Sellers = new List<ISeller>();
        }
    }
}
