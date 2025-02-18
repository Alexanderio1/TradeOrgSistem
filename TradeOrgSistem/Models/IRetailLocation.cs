using System.Collections.Generic;

namespace TradeOrgSistem.Models
{
    public interface IRetailLocation
    {
        int Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        IReadOnlyList<InventoryItem> Inventory { get; }
        void AddInventoryItem(InventoryItem item);
        void RemoveInventoryItem(int productId);
        decimal Area { get; set; }
        int NumberOfHalls { get; set; }
        int NumberOfCounters { get; set; }
        decimal Rent { get; set; }
        decimal Utilities { get; set; }
    }
}
