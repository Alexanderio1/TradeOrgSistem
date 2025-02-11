using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса объёма продаж для указанного товара.
    /// </summary>
    public class ProductSalesVolumeQueryResult
    {
        /// <summary>
        /// Идентификатор товара.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Название товара (для удобства пользователя).
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Общий объём продаж за заданный период.
        /// </summary>
        public int TotalSalesVolume { get; set; }
    }
}
