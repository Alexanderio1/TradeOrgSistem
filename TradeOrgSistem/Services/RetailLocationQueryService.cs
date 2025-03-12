using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class RetailLocationQueryService
    {
        private readonly DataRepository _repository;

        public RetailLocationQueryService()
        {
            _repository = DataRepository.Instance;
        }

        public InventoryQueryResult GetInventoryForRetailLocation(int? retailLocationId, string retailLocationName)
        {
            RetailLocation location = null;

            if (retailLocationId.HasValue)
            {
                location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
            }

            if (location == null)
                throw new InvalidOperationException("Торговая точка не найдена. Проверьте введенные данные.");

            var inventoryItems = location.Inventory.Select(invItem =>
            {
                var product = _repository.Data.Products.FirstOrDefault(p => p.Id == invItem.ProductId);
                return new InventoryItemDetail
                {
                    ProductId = invItem.ProductId,
                    ProductName = product != null ? product.Name : "Неизвестный товар",
                    Volume = invItem.Volume
                };
            }).ToList();

            return new InventoryQueryResult { InventoryItems = inventoryItems };
        }
    }
}
