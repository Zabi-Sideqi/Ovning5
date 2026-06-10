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
    }
}
