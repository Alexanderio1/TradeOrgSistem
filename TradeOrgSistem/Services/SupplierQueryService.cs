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
    /// Сервис для получения перечня поставщиков по критериям:
    /// () указанный вид товара (по типу), либо конкретный товар (по его ID или имени)
    /// () поставки с объёмом не менее заданного
    /// () за весь период или за указанный период.
    /// </summary>
    public class SupplierQueryService
    {
        private readonly DataRepository _repository;

        public SupplierQueryService()
        {
            // Используем Singleton-экземпляр DataRepository для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// получает перечень и общее число поставщиков, удовлетворяющих следующим условиям:
        /// - если указан productId, выбираются поставки конкретного товара;
        ///   иначе, если задан productName – производится поиск по имени товара (без учета регистра);
        ///   если и productName не задан, то при наличии productType – выборка по типу товара.
        /// - Если задан minVolume, учитываются только поставки, где объем не менее заданного.
        /// - Если заданы startDate и/или endDate, поставки фильтруются по периоду.
        /// </summary>
        /// <param name="productType">
        /// Тип товара, если требуется выбрать поставки товаров этого типа (используется, если не задан productId и productName).
        /// </param>
        /// <param name="productId">
        /// ID товара, если требуется выбрать поставки конкретного товара.
        /// </param>
        /// <param name="productName">
        /// Название товара, если ID не задан и требуется выбрать поставки по имени.
        /// </param>
        /// <param name="minVolume">
        /// Минимальный объем поставки.
        /// </param>
        /// <param name="startDate">
        /// Начало периода для фильтрации поставок (если задан).
        /// </param>
        /// <param name="endDate">
        /// Конец периода для фильтрации поставок (если задан).
        /// </param>
        /// <returns>
        /// Объект SupplierQueryResult, содержащий перечень поставщиков и их общее число.
        /// </returns>
        public SupplierQueryResult GetSuppliersByProductCriteria(string productType, int? productId, string productName, int? minVolume, DateTime? startDate, DateTime? endDate)
        {
            // Получаем все поставки из репозитория
            var deliveries = _repository.Data.Deliveries.AsEnumerable();

            // Фильтрация по периоду (если заданы даты)
            if (startDate.HasValue)
                deliveries = deliveries.Where(d => d.Date >= startDate.Value);
            if (endDate.HasValue)
                deliveries = deliveries.Where(d => d.Date <= endDate.Value);

            // Фильтрация по объему поставки
            if (minVolume.HasValue)
                deliveries = deliveries.Where(d => d.Volume >= minVolume.Value);

            // Фильтрация по конкретному товару или по его имени/типу
            if (productId.HasValue)
            {
                deliveries = deliveries.Where(d => d.ProductId == productId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(productName))
            {
                deliveries = deliveries.Where(d =>
                    _repository.Data.Products.Any(p =>
                        p.Id == d.ProductId &&
                        p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)));
            }
            else if (!string.IsNullOrWhiteSpace(productType))
            {
                deliveries = deliveries.Where(d =>
                    _repository.Data.Products.Any(p =>
                        p.Id == d.ProductId &&
                        p.Type.Equals(productType, StringComparison.OrdinalIgnoreCase)));
            }

            // Получаем уникальные ID поставщиков из отфильтрованных поставок
            var supplierIds = deliveries.Select(d => d.SupplierId).Distinct();

            // Получаем список поставщиков, сопоставляя с данными в репозитории
            var suppliers = _repository.Data.Suppliers.Where(s => supplierIds.Contains(s.Id)).ToList();

            return new SupplierQueryResult
            {
                Suppliers = suppliers,
                TotalCount = suppliers.Count
            };
        }
    }
}
