using System.Collections.Generic;

namespace TradeOrgSistem.Models
{
    public interface IRetailLocation
    {
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        IReadOnlyList<IInventoryItem> Inventory { get; }
        void AddInventoryItem(IInventoryItem item);
        void RemoveInventoryItem(int productId);
        decimal Area { get; set; }
        int NumberOfHalls { get; set; }
        int NumberOfCounters { get; set; }  // число прилавков
        decimal Rent { get; set; }          // ежемесячная арендная плата
        decimal Utilities { get; set; }     // ежемесячные коммунальные платежи
    }
}
