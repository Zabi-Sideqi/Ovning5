using System;
using System.Collections.Generic;
using System.Text;
using GarageExercise.Interface;
using GarageExercise.Models;

namespace GarageExercise.UI
{
    public class ConsoleUI : IUI
    {
        private readonly IHandler handler;
        

        public ConsoleUI(IHandler handler)
        {
            this.handler = handler;
        }

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("============Garage Menu ============");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Remove Vehicle");
                Console.WriteLine("3. Find Vehicle");
                Console.WriteLine("4. Show All Vehicles");
                Console.WriteLine("0. Exit");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.Write("Registration Number: ");
                        string registrationNumber = Console.ReadLine()!;

                        Console.Write("Color: ");
                        string color = Console.ReadLine()!;

                        Console.Write("Number Of Wheels: ");
                        int numberOfWheels = int.Parse(Console.ReadLine()!);

                        Console.Write("Fuel Type: ");
                        string fuelType = Console.ReadLine()!;

                        Car car = new Car(
                            registrationNumber,
                            color,
                            numberOfWheels,
                            fuelType);

                        bool added = handler.AddVehicle(car);

                        if (added)
                        {
                            Console.WriteLine("Vehicle added successfully");
                        }
                        else
                        {
                            Console.WriteLine("Vehicle could not be added");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Remove Vehicle selected");
                        break;

                    case "3":
                        Console.Write("Registration Number: ");
                        string registrationNumberToFind = Console.ReadLine()!;

                        Vehicle? foundVehicle =
                            handler.FindVehicle(registrationNumberToFind);
                        if (foundVehicle != null)
                        {
                            Console.WriteLine(foundVehicle);
                        }
                        else
                        {
                            Console.WriteLine("Vehicle not found");
                        }
                        break;

                    case "4":
                        foreach (var vehicle in handler.GetAllVehicles())
                        {
                            Console.WriteLine(vehicle);
                        }
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();


            }

        }
    }
}
