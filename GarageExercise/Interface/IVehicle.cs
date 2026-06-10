using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Interface
{
    public interface IVehicle
    {
        string RegistrationNumber { get; set; }
        string Color { get; set; }
        int NumberOfWheels { get; set; }
    }
}
