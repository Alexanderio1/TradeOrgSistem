using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeOrgSistem.Models
{
    public class Customer : ICustomer
    {
        private int _id;
        private string _name;

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Id), "ID покупателя должен быть положительным.");
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя покупателя не может быть пустым.", nameof(Name));
                _name = value;
            }
        }
    }
}
