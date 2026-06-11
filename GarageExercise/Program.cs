using GarageExercise.Garage;
using GarageExercise.Handlers;
using GarageExercise.Interface;
using GarageExercise.Models;
using GarageExercise.UI;

namespace GarageExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter garage capacity: ");
            int capacity =
                int.Parse(Console.ReadLine()!);

            IGarage<Vehicle> garage =
                new Garage<Vehicle>(capacity);

            IHandler handler =
                new GarageHandler(garage);

            handler.AddVehicle(
                new Car("ABC123", "Red", 4, "Gasoline"));

            handler.AddVehicle(
                new Bus("BUS111", "Blue", 6, 50));

            IUI ui =
                new ConsoleUI(handler);

            ui.Start();
        }
    }
}



// program är våra startpunkt i vår applikation,
