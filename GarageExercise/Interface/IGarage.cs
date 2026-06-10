using System;
using System.Collections.Generic;
using System.Text;
using GarageExercise.Models;


namespace GarageExercise.Interface
{
    public interface IGarage<T> where T : Vehicle
    {
        bool AddVehicle(T vehicle);
        bool RemoveVehicle( string registrationNumber);

        T? FindVehicle(string registrationNumber );

        int Capacity { get; }
        int Count { get; }
    }
}
