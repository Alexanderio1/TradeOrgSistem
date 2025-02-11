using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    //детали поставки
    public class DeliveryRecord
    {
        public int DeliveryId { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
    }

    public class DeliveryQueryResult
    {
        public List<DeliveryRecord> Deliveries { get; set; }
        public int TotalCount { get; set; }
    }
}
