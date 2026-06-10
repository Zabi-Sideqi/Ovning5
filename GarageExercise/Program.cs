using GarageExercise.Garage;
using GarageExercise.Handlers;
using GarageExercise.Interface;
using GarageExercise.Models;
using GarageExercise.UI;
using System.Diagnostics.Metrics;

namespace GarageExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUI ui = new ConsoleUI();

            ui.Start();
        }
    }

}




// program är våra startpunkt i vår applikation,
