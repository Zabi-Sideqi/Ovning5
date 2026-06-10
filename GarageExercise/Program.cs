using GarageExercise.Garage;
using GarageExercise.Models;

namespace GarageExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(10);

            garage.AddVehicle(
                new Car("ABC123", "Black", 4, "Gasoline"));

            garage.AddVehicle(
                new Car("DEF456", "Red", 4, "Diesel"));

            garage.AddVehicle(
                new Bus("BUS111", "Blue", 6, 50));

            var cars = garage.SearchByType("Car");

            foreach (var vehicle in cars)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}


// program är våra startpunkt i vår applikation,
