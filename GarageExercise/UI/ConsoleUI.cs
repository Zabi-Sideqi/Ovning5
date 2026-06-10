using System;
using System.Collections.Generic;
using System.Text;
using GarageExercise.Interface;

namespace GarageExercise.UI
{
    public class ConsoleUI : IUI
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("====Garage Menu====");
            Console.WriteLine("1.Add Vehicle");
            Console.WriteLine("2.Remove Vehicle");
            Console.WriteLine("3. Find Vehicle");
            Console.WriteLine("0. Exit");
        }
    }
}
