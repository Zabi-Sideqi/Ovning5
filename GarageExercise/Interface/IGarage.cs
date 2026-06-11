using System;
using System.Collections.Generic;
using System.Text;
using GarageExercise.Models;


namespace GarageExercise.Interface
{
    public interface IGarage<T> : IEnumerable<T> where T : Vehicle
    {
        bool AddVehicle(T vehicle);
        bool RemoveVehicle( string registrationNumber);

        T? FindVehicle(string registrationNumber );
        Dictionary<string, int> GetVehicleTypesCount();
        List<T> SearchByType(string type);
        List<T> SearchByColorAndWheels(
            string color,
            int numberOfWheels);

        int Capacity { get; }
        int Count { get; }
    }
}
