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
            
            int capacity;
            while (true)
            {
                Console.WriteLine("Enter garage capacity: ");
                if(int.TryParse(Console.ReadLine(), out capacity))
                {
                    break;
                }
                Console.WriteLine("Invalid number. Try again. ");
            }
                

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
