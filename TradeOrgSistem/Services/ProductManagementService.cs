using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class ProductManagementService
    {
        private readonly DataRepository _repository;

        public ProductManagementService()
        {
            _repository = DataRepository.Instance;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.Data.Products;
        }

        /// <summary>
        /// Возвращает следующий доступный ID для нового товара.
        /// Если список пуст, возвращает 1.
        /// </summary>
        public int GetNextProductId()
        {
            if (_repository.Data.Products == null || !_repository.Data.Products.Any())
                return 1;
            return _repository.Data.Products.Max(p => p.Id) + 1;
        }

        public void AddProduct(Product newProduct)
        {
            if (_repository.Data.Products.Any(p => p.Id == newProduct.Id))
                throw new InvalidOperationException("Товар с таким ID уже существует.");
            _repository.Data.Products.Add(newProduct);

            // Сохраняем изменения в файл
            _repository.SaveData();
        }

        public void UpdateProduct(Product updatedProduct)
        {
            var product = _repository.Data.Products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (product == null)
                throw new InvalidOperationException("Товар не найден.");
            product.Name = updatedProduct.Name;
            product.Type = updatedProduct.Type;

            // Сохраняем изменения в файл
            _repository.SaveData();
        }

        public void DeleteProduct(int productId)
        {
            var product = _repository.Data.Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
                throw new InvalidOperationException("Товар не найден.");
            _repository.Data.Products.Remove(product);

            // Сохраняем изменения в файл
            _repository.SaveData();
        }
    }
}
