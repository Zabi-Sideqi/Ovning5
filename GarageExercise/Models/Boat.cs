using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Models
{
    public class Boat : Vehicle
    {
        public double Length { get; set; }
        public Boat(
            string registrationNumber,
            string color,
            int numberOfWheels,
            double length)
            : base (registrationNumber, color, numberOfWheels)
        {
            Length = length;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $", Boat Length: {Length}";
        }
    }
}
