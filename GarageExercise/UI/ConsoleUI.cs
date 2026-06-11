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
                Console.WriteLine("5. Show Vehicle Statistics");
                Console.WriteLine("6. Search Vehicles");
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
                        Console.Write("Registration Number: ");

                        string registrationNumberToRemove = Console.ReadLine()!;

                        bool removed =
                            handler.RemoveVehicle(registrationNumberToRemove);
                        if (removed)
                        {
                            Console.WriteLine("Vehicle removed");
                        }
                        else
                        {
                            Console.WriteLine("Vehicle not found");
                        }

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
                    case "5":
                        var statistics =
                        handler.GetVehicleTypesCount();
                        foreach (var item in statistics)
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }
                        break;

                    case "6":
                        Console.WriteLine("1. Search By Type");
                        Console.WriteLine("2. Search By Color And Wheels");

                        string? searchChoice = Console.ReadLine()!;
                        switch (searchChoice)
                        {
                            case "1":
                                Console.Write("Vehicle Type: ");
                                string type = Console.ReadLine()!;
                                var vehiclesByType =
                                   handler.SearchByType(type);
                                foreach (var vehicle in vehiclesByType)
                                {
                                    Console.WriteLine(vehicle);
                                }
                                break;
                            case "2":

                                Console.Write("Color: ");

                                string searchColor =
                                    Console.ReadLine()!;

                                Console.Write("Number Of Wheels: ");

                                int wheels =
                                    int.Parse(Console.ReadLine()!);

                                var vehicles =
                                    handler.SearchByColorAndWheels(
                                        searchColor,
                                        wheels);

                                foreach (var vehicle in vehicles)
                                {
                                    Console.WriteLine(vehicle);
                                }

                                break;
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
