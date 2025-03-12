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

        public List<Customer> GetAllCustomers()
        {
            return _repository.Data.Customers;
        }

        public int GetNextCustomerId()
        {
            if (_repository.Data.Customers == null || !_repository.Data.Customers.Any())
                return 1;
            return _repository.Data.Customers.Max(c => c.Id) + 1;
        }

        public void AddCustomer(Customer newCustomer)
        {
            if (_repository.Data.Customers.Any(c => c.Id == newCustomer.Id))
                throw new InvalidOperationException("Покупатель с таким ID уже существует.");
            _repository.Data.Customers.Add(newCustomer);
            _repository.SaveData();
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            var customer = _repository.Data.Customers.FirstOrDefault(c => c.Id == updatedCustomer.Id);
            if (customer == null)
                throw new InvalidOperationException("Покупатель не найден.");
            customer.Name = updatedCustomer.Name;
            _repository.SaveData();
        }

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
