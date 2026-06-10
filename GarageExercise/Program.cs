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
            IUI ui = new ConsoleUI();

            ui.ShowMainMenu();
        }
    }
}


// program är våra startpunkt i vår applikation,
