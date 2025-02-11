using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Seller : ISeller
    {
        private int _id;
        private string _name;
        private int _retailLocationId;
        private decimal _salary;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя продавца не может быть пустым.", nameof(Name));
                _name = value;
            }
        }

        public int RetailLocationId
        {
            get => _retailLocationId;
            set => _retailLocationId = value;
        }

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Salary), "Зарплата не может быть отрицательной.");
                _salary = value;
            }
        }
    }
}
