using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения перечня и общего числа покупателей, которые:
    /// - Купили указанный товар (определяемый по ID, названию или типу).
    /// - Совершили покупку в указанном периоде (если заданы startDate и endDate).
    /// - Совершили покупку с объёмом не менее заданного (если задан minVolume).
    /// </summary>
    public class CustomerQueryService
    {
        private readonly DataRepository _repository;

        public CustomerQueryService()
        {
            // Используем Singleton-экземпляр DataRepository для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает перечень и общее число покупателей по следующим критериям:
        /// - Если задан productId, производится фильтрация по этому товару.
        /// - Если productId не задан, но задан productName – поиск производится по названию товара (без учета регистра).
        /// - Если ни productId, ни productName не заданы, а указан productType – выборка производится по типу товара.
        /// Дополнительно могут быть заданы:
        /// - Период (startDate и endDate), в течение которого совершена покупка.
        /// - Минимальный объём покупки (minVolume).
        /// </summary>
        /// <param name="productType">
        /// Тип товара (используется, если не задан productId и productName).
        /// </param>
        /// <param name="productId">
        /// ID товара (приоритетный параметр).
        /// </param>
        /// <param name="productName">
        /// Название товара (используется, если не задан productId).
        /// </param>
        /// <param name="minVolume">
        /// Минимальный объём покупки.
        /// </param>
        /// <param name="startDate">
        /// Начало периода для фильтрации покупок (если задано).
        /// </param>
        /// <param name="endDate">
        /// Конец периода для фильтрации покупок (если задано).
        /// </param>
        /// <returns>
        /// Объект CustomerQueryResult, содержащий перечень покупателей и их общее число.
        /// </returns>
        public CustomerQueryResult GetCustomersByProductCriteria(string productType, int? productId, string productName, int? minVolume, DateTime? startDate, DateTime? endDate)
        {
            // Получаем все продажи (покупки) из репозитория
            var sales = _repository.Data.Sales.AsEnumerable();

            // Фильтруем по периоду, если заданы даты
            if (startDate.HasValue)
                sales = sales.Where(s => s.Date >= startDate.Value);
            if (endDate.HasValue)
                sales = sales.Where(s => s.Date <= endDate.Value);

            // Фильтруем по объёму покупки, если задан минимальный объём
            if (minVolume.HasValue)
                sales = sales.Where(s => s.Volume >= minVolume.Value);

            // Приоритет фильтрации:
            // 1. Если задан productId – выбираем продажи этого товара.
            // 2. Если не задан productId, но задан productName – ищем по названию товара.
            // 3. Если ни productId, ни productName не заданы, но указан productType – ищем по типу товара.
            if (productId.HasValue)
            {
                sales = sales.Where(s => s.ProductId == productId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(productName))
            {
                sales = sales.Where(s =>
                    _repository.Data.Products.Any(p =>
                        p.Id == s.ProductId &&
                        p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)));
            }
            else if (!string.IsNullOrWhiteSpace(productType))
            {
                sales = sales.Where(s =>
                    _repository.Data.Products.Any(p =>
                        p.Id == s.ProductId &&
                        p.Type.Equals(productType, StringComparison.OrdinalIgnoreCase)));
            }

            // Из отфильтрованных продаж получаем уникальные ID покупателей
            var customerIds = sales.Select(s => s.CustomerId).Distinct();

            // Получаем список покупателей по их ID
            var customers = _repository.Data.Customers.Where(c => customerIds.Contains(c.Id)).ToList();

            return new CustomerQueryResult
            {
                Customers = customers,
                TotalCount = customers.Count
            };
        }
    }
}
