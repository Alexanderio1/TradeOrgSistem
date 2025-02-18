using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения сведений о наиболее активных покупателях.
    /// Фильтрация может осуществляться по периоду и по торговым точкам:
    /// по всем торговым точкам, по торговым точкам заданного типа или по конкретной торговой точке.
    /// </summary>
    public class ActiveCustomerQueryService
    {
        private readonly DataRepository _repository;

        public ActiveCustomerQueryService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает сведения о покупателях, агрегируя продажи по указанным фильтрам.
        /// Если заданы startDate и/или endDate, используются для фильтрации по периоду.
        /// Фильтрация по торговой точке осуществляется согласно следующему приоритету:
        /// retailLocationId > retailLocationName > retailLocationType.
        /// </summary>
        /// <param name="startDate">
        /// Начало периода (опционально).
        /// </param>
        /// <param name="endDate">
        /// Конец периода (опционально).
        /// </param>
        /// <param name="retailLocationId">
        /// ID торговой точки (если задан, используется для фильтрации).
        /// </param>
        /// <param name="retailLocationName">
        /// Название торговой точки (используется, если retailLocationId не задан).
        /// </param>
        /// <param name="retailLocationType">
        /// Тип торговой точки (используется, если ни retailLocationId, ни retailLocationName не заданы).
        /// </param>
        /// <returns>
        /// Объект ActiveCustomerQueryResult, содержащий список активных покупателей и общее число записей.
        /// Список отсортирован по убыванию TotalSalesVolume.
        /// </returns>
        public ActiveCustomerQueryResult GetActiveCustomers(
            DateTime? startDate,
            DateTime? endDate,
            int? retailLocationId,
            string retailLocationName,
            string retailLocationType)
        {
            // Начинаем с выборки всех продаж
            var sales = _repository.Data.Sales.AsEnumerable();

            // Фильтруем по периоду, если заданы даты
            if (startDate.HasValue)
                sales = sales.Where(s => s.Date >= startDate.Value);
            if (endDate.HasValue)
                sales = sales.Where(s => s.Date <= endDate.Value);

            // Фильтрация по торговой точке:
            if (retailLocationId.HasValue)
            {
                sales = sales.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location != null)
                    sales = sales.Where(s => s.RetailLocationId == location.Id);
                else
                    // Если торговая точка не найдена, можно считать, что выборка пуста
                    sales = Enumerable.Empty<Sale>();
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id);
                sales = sales.Where(s => locationIds.Contains(s.RetailLocationId));
            }
            // Если ни один параметр фильтрации по торговой точке не задан, используются продажи по всем торговым точкам.

            // Группируем продажи по покупателям (CustomerId)
            var customerGroups = sales.GroupBy(s => s.CustomerId);

            // Для каждого покупателя вычисляем суммарный объём, выручку и число транзакций
            var activeCustomerRecords = customerGroups.Select(g =>
            {
                int totalVolume = g.Sum(s => s.Volume);
                decimal totalRevenue = g.Sum(s => s.Volume * s.Price);
                int numberOfTransactions = g.Count();

                // Находим покупателя для получения имени
                var customer = _repository.Data.Customers.FirstOrDefault(c => c.Id == g.Key);
                string customerName = customer != null ? customer.Name : "Неизвестный покупатель";

                return new ActiveCustomerRecord
                {
                    CustomerId = g.Key,
                    CustomerName = customerName,
                    TotalSalesVolume = totalVolume,
                    TotalSalesRevenue = totalRevenue,
                    NumberOfTransactions = numberOfTransactions
                };
            })
            // Сортируем по убыванию суммарного объёма покупок (показатель активности)
            .OrderByDescending(r => r.TotalSalesVolume)
            .ToList();

            return new ActiveCustomerQueryResult
            {
                ActiveCustomers = activeCustomerRecords,
                TotalCount = activeCustomerRecords.Count
            };
        }
    }
}
