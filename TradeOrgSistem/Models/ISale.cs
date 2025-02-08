using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public interface ISale
    {
        int Id { get; set; }
        int CustomerId { get; set; }
        int RetailLocationId { get; set; }
        int SellerId { get; set; }
        int ProductId { get; set; }
        DateTime Date { get; set; }
        int Volume { get; set; }
        decimal Price { get; set; }
    }
}
