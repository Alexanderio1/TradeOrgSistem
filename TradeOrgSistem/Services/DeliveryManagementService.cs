using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class DeliveryManagementService
    {
        private readonly DataRepository _repository;

        public DeliveryManagementService()
        {
            _repository = DataRepository.Instance;
        }

        public List<Delivery> GetAllDeliveries()
        {
            return _repository.Data.Deliveries;
        }

        public int GetNextDeliveryId()
        {
            if (_repository.Data.Deliveries == null || !_repository.Data.Deliveries.Any())
                return 1;
            return _repository.Data.Deliveries.Max(d => d.Id) + 1;
        }

        public void AddDelivery(Delivery newDelivery)
        {
            if (_repository.Data.Deliveries.Any(d => d.Id == newDelivery.Id))
                throw new InvalidOperationException("Поставка с таким ID уже существует.");
            _repository.Data.Deliveries.Add(newDelivery);
            _repository.SaveData();
        }

        public void UpdateDelivery(Delivery updatedDelivery)
        {
            var delivery = _repository.Data.Deliveries.FirstOrDefault(d => d.Id == updatedDelivery.Id);
            if (delivery == null)
                throw new InvalidOperationException("Поставка не найдена.");
            delivery.SupplierId = updatedDelivery.SupplierId;
            delivery.ProductId = updatedDelivery.ProductId;
            delivery.Date = updatedDelivery.Date;
            delivery.Volume = updatedDelivery.Volume;
            delivery.Price = updatedDelivery.Price;
            delivery.OrderNumber = updatedDelivery.OrderNumber;
            _repository.SaveData();
        }

        public void DeleteDelivery(int deliveryId)
        {
            var delivery = _repository.Data.Deliveries.FirstOrDefault(d => d.Id == deliveryId);
            if (delivery == null)
                throw new InvalidOperationException("Поставка не найдена.");
            _repository.Data.Deliveries.Remove(delivery);
            _repository.SaveData();
        }
    }
}
