using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class SaleManagementService
    {
        private readonly DataRepository _repository;

        public SaleManagementService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Возвращает список всех продаж.
        /// </summary>
        public List<Sale> GetAllSales()
        {
            return _repository.Data.Sales;
        }

        /// <summary>
        /// Возвращает следующий доступный ID для новой продажи.
        /// Если список пуст, возвращает 1.
        /// </summary>
        public int GetNextSaleId()
        {
            if (_repository.Data.Sales == null || !_repository.Data.Sales.Any())
                return 1;
            return _repository.Data.Sales.Max(s => s.Id) + 1;
        }

        /// <summary>
        /// Добавляет новую продажу.
        /// </summary>
        public void AddSale(Sale newSale)
        {
            if (_repository.Data.Sales.Any(s => s.Id == newSale.Id))
                throw new InvalidOperationException("Продажа с таким ID уже существует.");
            _repository.Data.Sales.Add(newSale);
            _repository.SaveData();
        }

        /// <summary>
        /// Обновляет данные существующей продажи.
        /// </summary>
        public void UpdateSale(Sale updatedSale)
        {
            var sale = _repository.Data.Sales.FirstOrDefault(s => s.Id == updatedSale.Id);
            if (sale == null)
                throw new InvalidOperationException("Продажа не найдена.");
            sale.CustomerId = updatedSale.CustomerId;
            sale.RetailLocationId = updatedSale.RetailLocationId;
            sale.SellerId = updatedSale.SellerId;
            sale.ProductId = updatedSale.ProductId;
            sale.Date = updatedSale.Date;
            sale.Volume = updatedSale.Volume;
            sale.Price = updatedSale.Price;
            _repository.SaveData();
        }

        /// <summary>
        /// Удаляет продажу по ID.
        /// </summary>
        public void DeleteSale(int saleId)
        {
            var sale = _repository.Data.Sales.FirstOrDefault(s => s.Id == saleId);
            if (sale == null)
                throw new InvalidOperationException("Продажа не найдена.");
            _repository.Data.Sales.Remove(sale);
            _repository.SaveData();
        }
    }
}
