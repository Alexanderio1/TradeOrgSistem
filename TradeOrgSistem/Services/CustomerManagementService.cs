using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class CustomerManagementService
    {
        private readonly DataRepository _repository;

        public CustomerManagementService()
        {
            _repository = DataRepository.Instance;
        }

        /// <summary>
        /// Возвращает список всех покупателей.
        /// </summary>
        public List<Customer> GetAllCustomers()
        {
            return _repository.Data.Customers;
        }

        /// <summary>
        /// Возвращает следующий доступный ID для нового покупателя.
        /// Если список пуст, возвращает 1.
        /// </summary>
        public int GetNextCustomerId()
        {
            if (_repository.Data.Customers == null || !_repository.Data.Customers.Any())
                return 1;
            return _repository.Data.Customers.Max(c => c.Id) + 1;
        }

        /// <summary>
        /// Добавляет нового покупателя.
        /// </summary>
        public void AddCustomer(Customer newCustomer)
        {
            if (_repository.Data.Customers.Any(c => c.Id == newCustomer.Id))
                throw new InvalidOperationException("Покупатель с таким ID уже существует.");
            _repository.Data.Customers.Add(newCustomer);
            _repository.SaveData();
        }

        /// <summary>
        /// Обновляет данные существующего покупателя.
        /// </summary>
        public void UpdateCustomer(Customer updatedCustomer)
        {
            var customer = _repository.Data.Customers.FirstOrDefault(c => c.Id == updatedCustomer.Id);
            if (customer == null)
                throw new InvalidOperationException("Покупатель не найден.");
            customer.Name = updatedCustomer.Name;
            // Можно обновить и другие свойства, если они есть.
            _repository.SaveData();
        }

        /// <summary>
        /// Удаляет покупателя по ID.
        /// </summary>
        public void DeleteCustomer(int customerId)
        {
            var customer = _repository.Data.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
                throw new InvalidOperationException("Покупатель не найден.");
            _repository.Data.Customers.Remove(customer);
            _repository.SaveData();
        }
    }
}
