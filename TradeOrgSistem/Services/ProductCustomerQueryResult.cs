﻿using System.Collections.Generic;
using TradeOrgSistem.Models;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса о покупателях указанного товара.
    /// </summary>
    public class ProductCustomerQueryResult
    {
        public List<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }
}
