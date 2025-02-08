using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public interface IDelivery
    {
        int Id { get; set; }
        int SupplierId { get; set; }
        int ProductId { get; set; }
        DateTime Date { get; set; }
        int Volume { get; set; }
        decimal Price { get; set; }
    }
}
