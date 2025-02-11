using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения сведений об объёме продаж и ценах на указанный товар
    /// с возможностью фильтрации по торговым точкам.
    /// </summary>
    public class ProductPriceVolumeQueryService
    {
        private readonly DataRepository _repository;

        public ProductPriceVolumeQueryService()
        {
            // Используем Singleton-экземпляр DataRepository для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает сведения об объёме продаж и ценах для указанного товара.
        /// Фильтрация может производиться:
        /// – по всем торговым точкам (если ни retailLocationType, ни retailLocationId, ни retailLocationName не заданы),
        /// – по торговым точкам заданного типа (если указан retailLocationType),
        /// – по конкретной торговой точке (если задан retailLocationId или retailLocationName).
        /// Приоритет: retailLocationId > retailLocationName > retailLocationType.
        /// </summary>
        /// <param name="productId">ID товара (обязательный параметр)</param>
        /// <param name="retailLocationType">
        /// Тип торговой точки для фильтрации (используется, если не задан retailLocationId и retailLocationName).
        /// </param>
        /// <param name="retailLocationId">
        /// Конкретный ID торговой точки для фильтрации (приоритетный параметр).
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки для фильтрации (используется, если retailLocationId не задан).
        /// </param>
        /// <returns>
        /// Объект ProductPriceVolumeQueryResult с агрегированными данными:
        /// общий объём продаж, минимальную, максимальную и среднюю цену.
        /// </returns>
        public ProductPriceVolumeQueryResult GetProductPriceVolumeInfo(int productId, string retailLocationType, int? retailLocationId, string retailLocationName)
        {
            // Фильтруем продажи по заданному товару
            var sales = _repository.Data.Sales.Where(s => s.ProductId == productId);

            // Фильтрация по торговым точкам
            if (retailLocationId.HasValue)
            {
                // Если задан конкретный ID торговой точки, используем его
                sales = sales.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                // Если задано название торговой точки, ищем соответствующую торговую точку
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location == null)
                {
                    // Если торговая точка не найдена по названию, возвращаем результат с нулевыми значениями
                    return new ProductPriceVolumeQueryResult
                    {
                        ProductId = productId,
                        TotalVolume = 0,
                        MinPrice = 0,
                        MaxPrice = 0,
                        AveragePrice = 0
                    };
                }
                sales = sales.Where(s => s.RetailLocationId == location.Id);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                // Если задан тип торговой точки, выбираем ID торговых точек данного типа
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }
            // Если ни один фильтр по торговой точке не задан, используем все продажи для данного товара

            // Если по заданным критериям продаж не найдено, возвращаем результат с нулевыми значениями
            if (!sales.Any())
            {
                return new ProductPriceVolumeQueryResult
                {
                    ProductId = productId,
                    TotalVolume = 0,
                    MinPrice = 0,
                    MaxPrice = 0,
                    AveragePrice = 0
                };
            }

            int totalVolume = sales.Sum(s => s.Volume);
            decimal minPrice = sales.Min(s => s.Price);
            decimal maxPrice = sales.Max(s => s.Price);
            decimal avgPrice = sales.Average(s => s.Price);

            return new ProductPriceVolumeQueryResult
            {
                ProductId = productId,
                TotalVolume = totalVolume,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                AveragePrice = avgPrice
            };
        }
    }
}
