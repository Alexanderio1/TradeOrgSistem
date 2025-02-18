using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class DataRoot : IDataRoot
    {
        public List<Supplier> Suppliers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public List<Delivery> Deliveries { get; set; }
        public List<RetailLocation> RetailLocations { get; set; }
        public List<Sale> Sales { get; set; }
        public List<Seller> Sellers { get; set; }

        public DataRoot()
        {
            Suppliers = new List<Supplier>();
            Customers = new List<Customer>();
            Products = new List<Product>();
            Deliveries = new List<Delivery>();
            RetailLocations = new List<RetailLocation>();
            Sales = new List<Sale>();
            Sellers = new List<Seller>();
        }
    }
}
