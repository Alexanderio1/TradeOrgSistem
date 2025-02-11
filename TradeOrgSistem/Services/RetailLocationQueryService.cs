using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения номенклатуры и объёма товаров в указанной торговой точке.
    /// Позволяет искать торговую точку либо по ID, либо по названию.
    /// </summary>
    public class RetailLocationQueryService
    {
        private readonly DataRepository _repository;

        public RetailLocationQueryService()
        {
            // Используем Singleton-экземпляр DataRepository для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Возвращает номенклатуру и объём товаров для торговой точки,
        /// идентифицируемой либо по ID, либо по названию.
        /// Если задан retailLocationId, поиск идет по нему, иначе выполняется поиск по retailLocationName.
        /// </summary>
        /// <param name="retailLocationId">
        /// ID торговой точки (при наличии). Если задан, то retailLocationName игнорируется.
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки для поиска (без учета регистра), если ID не задан.
        /// </param>
        /// <returns>
        /// Объект InventoryQueryResult с перечнем товаров и их объемами.
        /// </returns>
        public InventoryQueryResult GetInventoryForRetailLocation(int? retailLocationId, string retailLocationName)
        {
            IRetailLocation location = null;

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

            // Для каждого элемента инвентаря находим соответствующий товар
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
