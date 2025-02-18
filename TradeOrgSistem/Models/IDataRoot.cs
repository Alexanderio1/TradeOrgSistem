using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public interface IDataRoot
    {
        List<Supplier> Suppliers { get; set; }
        List<Customer> Customers { get; set; }
        List<Product> Products { get; set; }
        List<Delivery> Deliveries { get; set; }
        List<RetailLocation> RetailLocations { get; set; }
        List<Sale> Sales { get; set; }
        List<Seller> Sellers { get; set; }
    }
}
