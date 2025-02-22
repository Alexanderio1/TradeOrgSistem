using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class SellerManagementService
    {
        private readonly DataRepository _repository;

        public SellerManagementService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Возвращает список всех продавцов.
        /// </summary>
        public List<Seller> GetAllSellers()
        {
            return _repository.Data.Sellers;
        }

        /// <summary>
        /// Возвращает следующий доступный ID для нового продавца.
        /// Если список пуст, возвращает 1.
        /// </summary>
        public int GetNextSellerId()
        {
            if (_repository.Data.Sellers == null || !_repository.Data.Sellers.Any())
                return 1;
            return _repository.Data.Sellers.Max(s => s.Id) + 1;
        }

        /// <summary>
        /// Добавляет нового продавца.
        /// </summary>
        public void AddSeller(Seller newSeller)
        {
            if (_repository.Data.Sellers.Any(s => s.Id == newSeller.Id))
                throw new InvalidOperationException("Продавец с таким ID уже существует.");
            _repository.Data.Sellers.Add(newSeller);
            _repository.SaveData();
        }

        /// <summary>
        /// Обновляет данные существующего продавца.
        /// </summary>
        public void UpdateSeller(Seller updatedSeller)
        {
            var seller = _repository.Data.Sellers.FirstOrDefault(s => s.Id == updatedSeller.Id);
            if (seller == null)
                throw new InvalidOperationException("Продавец не найден.");
            seller.Name = updatedSeller.Name;
            seller.RetailLocationId = updatedSeller.RetailLocationId;
            seller.Salary = updatedSeller.Salary;
            _repository.SaveData();
        }

        /// <summary>
        /// Удаляет продавца по ID.
        /// </summary>
        public void DeleteSeller(int sellerId)
        {
            var seller = _repository.Data.Sellers.FirstOrDefault(s => s.Id == sellerId);
            if (seller == null)
                throw new InvalidOperationException("Продавец не найден.");
            _repository.Data.Sellers.Remove(seller);
            _repository.SaveData();
        }
    }
}
