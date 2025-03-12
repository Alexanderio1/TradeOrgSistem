using System;
using System.Collections.Generic;

namespace TradeOrgSistem.Services
{
    public class DeliveryOrderRecord
    {
        public int DeliveryId { get; set; }
        public string OrderNumber { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
    }

    public class DeliveryOrderQueryResult
    {
        public List<DeliveryOrderRecord> Deliveries { get; set; }
        public int TotalCount { get; set; }
    }
}
