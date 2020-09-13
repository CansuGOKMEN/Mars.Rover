using Mars.Rover.Core.Bussiness;
using Mars.Rover.Core.Bussiness.Redirection;
using Mars.Rover.Core.Model;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mars.Rover.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IRoverBussiness, RoverBussiness>();
            services.AddSingleton<IPlateauBussiness, PlateauBussiness>();
            services.AddSingleton<IExplore, Move>();

            IPlateauBussiness plateauBussiness = services.BuildServiceProvider().GetService<IPlateauBussiness>();
            IRoverBussiness roverBussiness = services.BuildServiceProvider().GetService<IRoverBussiness>();

            Console.WriteLine("Initializing started...");

            Plateau plateau = null;
            bool isCorrectSize = false;
            while (!isCorrectSize) // First input init. Correct Format. Some Validation.
            {
                Console.WriteLine("Okey captan give some coordinaties");
                string sizeInput = Console.ReadLine();
                plateau = plateauBussiness.sizeParse(sizeInput);

                if (plateau != null)
                    isCorrectSize = true;
            }

            Console.WriteLine("Kirk, rover first location");//First Line Rover Currenct Location
            string firstPosition = Console.ReadLine();
            Console.WriteLine("Rover direction"); //Second Line Rover Direction
            string direction = Console.ReadLine();

            Rovers currenctRover = roverBussiness.CurrentRover(firstPosition); //Binding Object...
            if (currenctRover != null)
            {
                roverBussiness.GetNewLocation(direction);
            }

            Console.WriteLine("Kirk Expected Output right here: {0} {1} {2}", currenctRover.RoverLocation.X, currenctRover.RoverLocation.Y, currenctRover.RoverLocation.Direction.ToString());


        }
    }
}
