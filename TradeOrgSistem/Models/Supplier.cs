using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Supplier : ISupplier
    {
        private int _id;
        private string _name;
        private readonly List<int> _productIds;

        public Supplier()
        {
            _productIds = new List<int>();
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Id), "ID поставщика должен быть положительным.");
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя поставщика не может быть пустым.", nameof(Name));
                _name = value;
            }
        }

        public IReadOnlyList<int> ProductIds => _productIds.AsReadOnly();

        public void AttachProduct(IProduct product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Продукт не может быть null.");
            if (product.Id <= 0)
                throw new ArgumentException("ID продукта должен быть положительным.", nameof(product));
            if (_productIds.Contains(product.Id))
                throw new InvalidOperationException("Продукт с таким ID уже привязан к поставщику.");
            _productIds.Add(product.Id);
        }

        public void DetachProduct(IProduct product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Продукт не может быть null.");
            if (!_productIds.Remove(product.Id))
                throw new InvalidOperationException("Продукт с данным ID не найден у поставщика.");
        }
    }
}
