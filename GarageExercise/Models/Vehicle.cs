using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Models
{
    public abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        protected Vehicle(
            string registrationNumber,
            string color,
            int numberOfWheels
            )

        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
        public override string ToString()
        {
            return $"Registration Number: {RegistrationNumber}, Color: {Color}, Number of Wheels: {NumberOfWheels}";
        }
    }
}
