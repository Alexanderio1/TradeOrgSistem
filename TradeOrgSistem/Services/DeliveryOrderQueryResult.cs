using System;
using System.Collections.Generic;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Детали поставки для отображения в запросе по номеру заказа.
    /// </summary>
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

    /// <summary>
    /// Результат запроса поставок по номеру заказа.
    /// </summary>
    public class DeliveryOrderQueryResult
    {
        public List<DeliveryOrderRecord> Deliveries { get; set; }
        public int TotalCount { get; set; }
    }
}
