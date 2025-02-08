using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Sale : ISale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RetailLocationId { get; set; }
        public int SellerId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
    }
}
