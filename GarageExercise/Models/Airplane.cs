using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise.Models
{
   public  class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public Airplane(
            string registrationNumber,
            string color,
            int numberOfWheels,
            int numberOfEngines)
            : base (registrationNumber, color, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;
        }
        public override string ToString()
        {
            return base.ToString() +
               $", Number Of Engines: {NumberOfEngines}";
        }
    }
}
