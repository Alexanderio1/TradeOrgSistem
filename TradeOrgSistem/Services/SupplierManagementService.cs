using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class SupplierManagementService
    {
        private readonly DataRepository _repository;

        public SupplierManagementService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Возвращает список всех поставщиков.
        /// </summary>
        public List<Supplier> GetAllSuppliers()
        {
            return _repository.Data.Suppliers;
        }

        /// <summary>
        /// Возвращает следующий доступный ID для нового поставщика (если нужно автоназначение).
        /// </summary>
        public int GetNextSupplierId()
        {
            if (_repository.Data.Suppliers == null || !_repository.Data.Suppliers.Any())
                return 1;
            return _repository.Data.Suppliers.Max(s => s.Id) + 1;
        }

        /// <summary>
        /// Добавляет нового поставщика.
        /// </summary>
        public void AddSupplier(Supplier newSupplier)
        {
            if (_repository.Data.Suppliers.Any(s => s.Id == newSupplier.Id))
                throw new InvalidOperationException("Поставщик с таким ID уже существует.");
            _repository.Data.Suppliers.Add(newSupplier);

            // Не забудьте вызвать сохранение, если хотите записывать в JSON:
            _repository.SaveData();
        }

        /// <summary>
        /// Обновляет существующего поставщика.
        /// </summary>
        public void UpdateSupplier(Supplier updatedSupplier)
        {
            var supplier = _repository.Data.Suppliers.FirstOrDefault(s => s.Id == updatedSupplier.Id);
            if (supplier == null)
                throw new InvalidOperationException("Поставщик не найден.");
            supplier.Name = updatedSupplier.Name;
            // При необходимости обновляйте другие поля (Products и т.д.)

            _repository.SaveData();
        }

        /// <summary>
        /// Удаляет поставщика по ID.
        /// </summary>
        public void DeleteSupplier(int supplierId)
        {
            var supplier = _repository.Data.Suppliers.FirstOrDefault(s => s.Id == supplierId);
            if (supplier == null)
                throw new InvalidOperationException("Поставщик не найден.");
            _repository.Data.Suppliers.Remove(supplier);

            _repository.SaveData();
        }
    }
}
