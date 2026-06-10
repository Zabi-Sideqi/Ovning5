using GarageExercise.Garage;
using GarageExercise.Handlers;
using GarageExercise.Interface;
using GarageExercise.Models;

namespace GarageExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGarage<Vehicle> garage =
                new Garage<Vehicle>(10);

            IHandler handler =
                new GarageHandler(garage);

            handler.AddVehicle(
                new Car("ABC123", "Red", 4, "Gasoline"));

            Vehicle? vehicle =
                handler.FindVehicle("ABC123");

            Console.WriteLine(vehicle);
        }
    }
}


// program är våra startpunkt i vår applikation,
