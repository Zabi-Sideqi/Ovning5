using System;
using System.Collections.Generic;
using System.Text;
using GarageExercise.Interface;

namespace GarageExercise.UI
{
    public class ConsoleUI : IUI
    {
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
                Console.WriteLine("0. Exit");

                string? choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Add Vehicle selected");
                        break;

                    case "2":
                        Console.WriteLine("Remove Vehicle selected");
                        break;

                    case "3":
                        Console.WriteLine("Find Vehicle selected");
                        break;

                    case " 0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ivalid choice");
                        break;


                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();


            }

        }
    }
}
