using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Delivery : IDelivery
    {
        private int _id;
        private int _supplierId;
        private int _productId;
        private DateTime _date;
        private int _volume;
        private decimal _price;
        private string _orderNumber;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int SupplierId
        {
            get => _supplierId;
            set => _supplierId = value;
        }

        public int ProductId
        {
            get => _productId;
            set => _productId = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public int Volume
        {
            get => _volume;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Volume), "Объём поставки не может быть отрицательным.");
                _volume = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Price), "Цена поставки не может быть отрицательной.");
                _price = value;
            }
        }

        public string OrderNumber
        {
            get => _orderNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Номер заказа не может быть пустым.", nameof(OrderNumber));
                _orderNumber = value;
            }
        }
    }
}
