using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Product : IProduct
    {
        private int _id;
        private string _name;
        private string _type;

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Id), "ID товара должен быть положительным.");
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя товара не может быть пустым.", nameof(Name));
                _name = value;
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Тип товара не может быть пустым.", nameof(Type));
                _type = value;
            }
        }
    }
}
