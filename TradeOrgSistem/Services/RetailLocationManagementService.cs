﻿using System;
using System.Collections.Generic;
using System.Linq;
using TradeOrgSistem.Models;
using TradeOrgSistem.Repository;

namespace TradeOrgSistem.Services
{
    public class RetailLocationManagementService
    {
        private readonly DataRepository _repository;

        public RetailLocationManagementService()
        {
            _repository = DataRepository.Instance;
        }

        public List<RetailLocation> GetAllRetailLocations()
        {
            return _repository.Data.RetailLocations;
        }

        public int GetNextRetailLocationId()
        {
            if (_repository.Data.RetailLocations == null || !_repository.Data.RetailLocations.Any())
                return 1;
            return _repository.Data.RetailLocations.Max(r => r.Id) + 1;
        }

        public void AddRetailLocation(RetailLocation newLocation)
        {
            if (_repository.Data.RetailLocations.Any(r => r.Id == newLocation.Id))
                throw new InvalidOperationException("Торговая точка с таким ID уже существует.");
            _repository.Data.RetailLocations.Add(newLocation);
            _repository.SaveData();
        }

        public void UpdateRetailLocation(RetailLocation updatedLocation)
        {
            var location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == updatedLocation.Id);
            if (location == null)
                throw new InvalidOperationException("Торговая точка не найдена.");
            location.Name = updatedLocation.Name;
            location.Type = updatedLocation.Type;
            location.Area = updatedLocation.Area;
            location.NumberOfHalls = updatedLocation.NumberOfHalls;
            location.NumberOfCounters = updatedLocation.NumberOfCounters;
            location.Rent = updatedLocation.Rent;
            location.Utilities = updatedLocation.Utilities;
            _repository.SaveData();
        }

        public void DeleteRetailLocation(int locationId)
        {
            var location = _repository.Data.RetailLocations.FirstOrDefault(r => r.Id == locationId);
            if (location == null)
                throw new InvalidOperationException("Торговая точка не найдена.");
            _repository.Data.RetailLocations.Remove(location);
            _repository.SaveData();
        }
    }
}
