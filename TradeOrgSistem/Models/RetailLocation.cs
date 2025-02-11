using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class RetailLocation : IRetailLocation
    {
        private int _id;
        private string _name;
        private string _type;
        private readonly List<IInventoryItem> _inventory;
        private decimal _area;
        private int _numberOfHalls;
        private int _numberOfCounters;
        private decimal _rent;
        private decimal _utilities;

        public RetailLocation()
        {
            _inventory = new List<IInventoryItem>();
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Id), "ID торговой точки должен быть положительным.");
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя торговой точки не может быть пустым.", nameof(Name));
                _name = value;
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Тип торговой точки не может быть пустым.", nameof(Type));
                _type = value;
            }
        }

        public IReadOnlyList<IInventoryItem> Inventory => _inventory.AsReadOnly();

        public void AddInventoryItem(IInventoryItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Элемент номенклатуры не может быть null.");
            if (_inventory.Any(i => i.ProductId == item.ProductId))
                throw new InvalidOperationException("Элемент номенклатуры с таким ProductId уже существует.");
            _inventory.Add(item);
        }

        public void RemoveInventoryItem(int productId)
        {
            var item = _inventory.FirstOrDefault(i => i.ProductId == productId);
            if (item == null)
                throw new InvalidOperationException("Элемент номенклатуры с данным ProductId не найден.");
            _inventory.Remove(item);
        }

        public decimal Area
        {
            get => _area;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Area), "Торговая площадь не может быть отрицательной.");
                _area = value;
            }
        }

        public int NumberOfHalls
        {
            get => _numberOfHalls;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(NumberOfHalls), "Число торговых залов не может быть отрицательным.");
                _numberOfHalls = value;
            }
        }

        public int NumberOfCounters
        {
            get => _numberOfCounters;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(NumberOfCounters), "Число прилавков не может быть отрицательным.");
                _numberOfCounters = value;
            }
        }

        public decimal Rent
        {
            get => _rent;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Rent), "Арендная плата не может быть отрицательной.");
                _rent = value;
            }
        }

        public decimal Utilities
        {
            get => _utilities;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Utilities), "Коммунальные платежи не могут быть отрицательными.");
                _utilities = value;
            }
        }
    }
}
