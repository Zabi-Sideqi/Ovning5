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
                        Vehicle newVehicle = CreateVehicle();
                        bool added = handler.AddVehicle(newVehicle);
                        if (added)
                        {
                            Console.WriteLine("Vehicle added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Vehcile coud not be added");
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


                                int wheels =
                                    ReadInt("Number Of Wheels: ");

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

        private Vehicle CreateVehicle()
        {
            Console.WriteLine("Choose Vehicle Type");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Boat");
            Console.WriteLine("4. Motorcycle");
            Console.WriteLine("5. Airplane");

            string? vehicleChoice = Console.ReadLine();

            switch (vehicleChoice)
            {
                case "1":
                    return CreateCar();

                case "2":
                    return CreateBus();

                case "3":
                    return CreateBoat();

                case "4":
                    return CreateMotorcycle();

                case "5":
                    return CreateAirplane();

                default:
                    Console.WriteLine("Invalid vehicle type");
                    return CreateCar();
            }
        }



        private string ReadRegistrationNumber()
        {
            Console.Write("Registration Number: ");
            return Console.ReadLine()!;
        }
        private string ReadColor()
        {
            Console.Write("Color: ");
            return Console.ReadLine()!;
        }
        private int ReadNumberOfWheels()
        {
            int wheels;

            Console.Write("Number Of Wheels: ");

            while (!int.TryParse(Console.ReadLine(), out wheels))
            {
                Console.Write("Invalid number. Try again: ");
            }

            return wheels;
        }

        private int ReadInt(string message)
        {
            int value;

            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number. Try again: ");
            }

            return value;
        }
        private double ReadDouble(string message)
        {
            double value;

            Console.Write(message);

            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number. Try again: ");
            }

            return value;
        }




        private Vehicle CreateCar()
        {
            string registrationNumber = ReadRegistrationNumber();
            string color = ReadColor();

            int numberOfWheels = ReadNumberOfWheels();


            Console.Write("Fuel Type: ");
            string fuelType = Console.ReadLine()!;

            return new Car(
                registrationNumber,
                color,
                numberOfWheels,
                fuelType);
        }
        private Vehicle CreateBus()
        {
            string registratonNumber = ReadRegistrationNumber();
            string color = ReadColor();
            int numberOfWheels = ReadNumberOfWheels();
            int numberOfSeats =
                ReadInt("Number Of Seats: ");

            return new Bus(
                registratonNumber,
                color,
                numberOfWheels,
                numberOfSeats);
        }

        private Vehicle CreateBoat()
        {
            string registrationNumber = ReadRegistrationNumber();
            string color = ReadColor();
            int numberOfWheels = ReadNumberOfWheels();

            double length = ReadDouble("Length: ");
            return new Boat(
                registrationNumber,
                color,
                numberOfWheels,
                length
                );


        }
        private Vehicle CreateMotorcycle()
        {
            string registrationNumber = ReadRegistrationNumber();
            string color = ReadColor();
            int numberOfWheels = ReadNumberOfWheels();
            
            int cylinderVolume = ReadInt("Cylinder Volume: ");
            return new Motorcycle(
                registrationNumber,
                color,
                numberOfWheels,
                cylinderVolume
                );
        }

        private Vehicle CreateAirplane()
        {
            string registrationNumber = ReadRegistrationNumber();
            string color = ReadColor();
            int numberOfWheels = ReadNumberOfWheels();
            
            int numberOfEngines = ReadInt("Number Of Engines: ");
            return new Airplane(
                registrationNumber,
                color,
                numberOfWheels,
                numberOfEngines
                );
        }
    }

}



