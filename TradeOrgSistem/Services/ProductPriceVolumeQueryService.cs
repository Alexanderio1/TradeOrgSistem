using System;
using System.Linq;
using TradeOrgSistem.Models;
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
        /// Фильтрация по торговым точкам:
        /// – если задан retailLocationId, используется он;
        /// – если ID не задан, но задано retailLocationName, производится поиск по названию (без учета регистра);
        /// – если ни ID, ни название не заданы, но указан retailLocationType, фильтруем по типу торговой точки;
        /// – если ни один параметр не указан, используются продажи по всем торговым точкам.
        /// Поиск товара производится по следующим параметрам:
        /// – если задан productId, используется он;
        /// – если productId не задан, но задан productName, выполняется поиск по имени (без учета регистра).
        /// Если ни один из параметров не указан, выбрасывается исключение.
        /// </summary>
        /// <param name="productId">ID товара (опционально)</param>
        /// <param name="productName">Название товара (опционально, используется если ID не задан)</param>
        /// <param name="retailLocationType">Тип торговой точки для фильтрации (если не заданы другие параметры)</param>
        /// <param name="retailLocationId">Конкретный ID торговой точки (приоритетный)</param>
        /// <param name="retailLocationName">Название торговой точки (если ID не задан)</param>
        /// <returns>Объект ProductPriceVolumeQueryResult с агрегированными данными</returns>
        public ProductPriceVolumeQueryResult GetProductPriceVolumeInfo(int? productId, string productName, string retailLocationType, int? retailLocationId, string retailLocationName)
        {
            // Определяем товар: если Product ID не задан, пытаемся найти по Product Name
            if (!productId.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(productName))
                {
                    var product = _repository.Data.Products
                        .FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
                    if (product == null)
                        throw new InvalidOperationException("Товар с указанным именем не найден.");
                    productId = product.Id;
                }
                else
                {
                    throw new InvalidOperationException("Необходимо указать либо Product ID, либо Product Name.");
                }
            }

            // Фильтруем продажи по заданному товару
            var sales = _repository.Data.Sales.Where(s => s.ProductId == productId.Value);

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
                        ProductId = productId.Value,
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
            // Если ни один фильтр по торговой точке не задан, используются продажи по всем торговым точкам.

            // Если по заданным критериям продаж не найдено, возвращаем результат с нулевыми значениями
            if (!sales.Any())
            {
                return new ProductPriceVolumeQueryResult
                {
                    ProductId = productId.Value,
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
                ProductId = productId.Value,
                TotalVolume = totalVolume,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                AveragePrice = avgPrice
            };
        }
    }
}
