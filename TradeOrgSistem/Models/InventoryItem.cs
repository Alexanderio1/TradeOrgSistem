using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeOrgSistem.Models
{
    public class InventoryItem : IInventoryItem
    {
        private int _productId;
        private int _volume;

        public int ProductId
        {
            get => _productId;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(ProductId), "ID продукта должен быть положительным.");
                _productId = value;
            }
        }

        public int Volume
        {
            get => _volume;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Volume), "Объём товара не может быть отрицательным.");
                _volume = value;
            }
        }
    }
}
