using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Результат запроса номенклатуры для торговой точки.
    /// </summary>
    public class InventoryQueryResult
    {
        /// <summary>
        /// Список деталей по каждому товару: ID товара, название и объем.
        /// </summary>
        public List<InventoryItemDetail> InventoryItems { get; set; }
    }

    /// <summary>
    /// Детали элемента инвентаря, включающие информацию о товаре.
    /// </summary>
    public class InventoryItemDetail
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Volume { get; set; }
    }
}
