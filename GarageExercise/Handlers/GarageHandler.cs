using GarageExercise.Interface;
using GarageExercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Handlers
{
    public class GarageHandler : IHandler
    {
        private readonly IGarage<Vehicle> garage;

        public GarageHandler(IGarage<Vehicle> garage)
        {
            this.garage = garage;
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            return garage.AddVehicle(vehicle);
        }

        public bool RemoveVehicle(string registrationNumber)
        {
            return garage.RemoveVehicle(registrationNumber);
        }
        public Vehicle? FindVehicle(string registrationNumber)
        {
            return garage.FindVehicle(registrationNumber);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return garage;
        }
        public Dictionary<string, int> GetVehicleTypesCount()
        {
            return garage.GetVehicleTypesCount();
        }
        public List<Vehicle> SearchByType(string type)
        {
            return garage.SearchByType(type);
        }
        public List<Vehicle> SearchByColorAndWheels(
            string color,
            int numberOfWheels)
        {
            return garage.SearchByColorAndWheels(
                color,
                numberOfWheels);
        }

        public List<Vehicle> SearchVehicle(
            string? registrationNumber,
            string? color,
            int? numberOfWheels)
        {
            return garage.SearchVehicles(
                registrationNumber,
                color,
                numberOfWheels);
        }
    }
}

