using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    /// <summary>
    /// Сервис для получения данных о заработной плате продавцов с фильтрацией по торговым точкам.
    /// </summary>
    public class SellerSalaryQueryService
    {
        private readonly DataRepository _repository;

        public SellerSalaryQueryService()
        {
            // Используем Singleton-экземпляр DataRepository для доступа к данным
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Получает данные о заработной плате продавцов.
        /// Фильтрация производится:
        /// – по всем торговым точкам (если не задан ни retailLocationType, ни retailLocationId, ни retailLocationName),
        /// – по торговым точкам заданного типа,
        /// – по конкретной торговой точке (если задан retailLocationId или retailLocationName).
        /// Приоритет: retailLocationId > retailLocationName > retailLocationType.
        /// </summary>
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
        /// Объект SellerSalaryQueryResult с деталями по заработной плате продавцов и общим числом найденных продавцов.
        /// </returns>
        public SellerSalaryQueryResult GetSellerSalaryData(string retailLocationType, int? retailLocationId, string retailLocationName)
        {
            // Получаем всех продавцов из репозитория
            var sellers = _repository.Data.Sellers.AsQueryable();

            // Фильтрация по торговой точке:
            if (retailLocationId.HasValue)
            {
                // Если задан конкретный ID торговой точки, выбираем продавцов, работающих в этой точке
                sellers = sellers.Where(s => s.RetailLocationId == retailLocationId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationName))
            {
                // Если задано название торговой точки, ищем торговую точку по названию
                var location = _repository.Data.RetailLocations
                    .FirstOrDefault(r => r.Name.Equals(retailLocationName, StringComparison.OrdinalIgnoreCase));
                if (location != null)
                {
                    sellers = sellers.Where(s => s.RetailLocationId == location.Id);
                }
                else
                {
                    // Если торговая точка не найдена, возвращаем пустой результат
                    return new SellerSalaryQueryResult
                    {
                        SellerSalaries = new List<SellerSalaryDetail>(),
                        TotalCount = 0
                    };
                }
            }
            else if (!string.IsNullOrWhiteSpace(retailLocationType))
            {
                // Если задан тип торговой точки, выбираем все торговые точки данного типа
                var locationIds = _repository.Data.RetailLocations
                    .Where(r => r.Type.Equals(retailLocationType, StringComparison.OrdinalIgnoreCase))
                    .Select(r => r.Id)
                    .ToList();
                sellers = sellers.Where(s => locationIds.Contains(s.RetailLocationId));
            }
            // Если ни один из параметров не задан, используются данные по всем торговым точкам.

            var sellerList = sellers.ToList();

            // Формируем список деталей: для каждого продавца получаем информацию о торговой точке
            var sellerSalaryDetails = sellerList.Select(s =>
            {
                var location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == s.RetailLocationId);
                return new SellerSalaryDetail
                {
                    SellerId = s.Id,
                    SellerName = s.Name,
                    Salary = s.Salary,
                    RetailLocationId = s.RetailLocationId,
                    RetailLocationName = location != null ? location.Name : "Неизвестная торговая точка"
                };
            }).ToList();

            return new SellerSalaryQueryResult
            {
                SellerSalaries = sellerSalaryDetails,
                TotalCount = sellerSalaryDetails.Count
            };
        }
    }
}
