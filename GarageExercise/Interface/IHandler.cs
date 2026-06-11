using GarageExercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Interface
{
    public interface IHandler
    {
        bool AddVehicle(Vehicle vehicle);
        bool RemoveVehicle(string registrationNumber);
        Vehicle? FindVehicle(string registrationNumber);
        IEnumerable<Vehicle> GetAllVehicles();
        Dictionary<string, int> GetVehicleTypesCount();

        List<Vehicle> SearchByType(string type);

        List<Vehicle> SearchByColorAndWheels(
            string color,
            int numberOfWheels);

    }
}
