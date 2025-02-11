using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class Sale : ISale
    {
        private int _id;
        private int _customerId;
        private int _retailLocationId;
        private int _sellerId;
        private int _productId;
        private DateTime _date;
        private int _volume;
        private decimal _price;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }

        public int RetailLocationId
        {
            get => _retailLocationId;
            set => _retailLocationId = value;
        }

        public int SellerId
        {
            get => _sellerId;
            set => _sellerId = value;
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
                    throw new ArgumentOutOfRangeException(nameof(Volume), "Объём продажи не может быть отрицательным.");
                _volume = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Price), "Цена продажи не может быть отрицательной.");
                _price = value;
            }
        }
    }
}
