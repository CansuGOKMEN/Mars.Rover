using Mars.Rover.Core.Bussiness.Redirection;
using Mars.Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static Mars.Rover.Core.Components.Enums;

namespace Mars.Rover.Core.Bussiness
{
    public class RoverBussiness : IRoverBussiness
    {
        RoverLocation roverLocation;

        public Rovers CurrentRover(string location)
        {
            if (string.IsNullOrEmpty(location))
            {
                Console.WriteLine("Spock give some coordinates...");
                return null;
            }

            var currectLocation = location.Split(' ');
            if (currectLocation.Length != 3)
            {
                Console.WriteLine("Spock... U're smart man. Right location pls.");
                return null;
            }

            var x = int.Parse(currectLocation[0]);
            var y = int.Parse(currectLocation[1]);

            string direction = currectLocation[2].ToUpper();
            Direction directionEnum;
            if (Enum.TryParse(direction, out directionEnum))
                roverLocation = new RoverLocation(x, y, directionEnum);
            else
            {
                Console.WriteLine("Spock... U're smart man. Right direction pls.");
                return null;
            }

            Rovers rover = new Rovers(roverLocation);
            return rover;
        }

        public void GetNewLocation(string redirection)
        {
            foreach (var letter in redirection.ToCharArray())
            {
                switch (char.ToUpper(letter))
                {
                    case 'L':
                        new TurnLeft().Explore(roverLocation);
                        break;
                    case 'R':
                        new TurnRight().Explore(roverLocation);
                        break;
                    case 'M':
                        new Move().Explore(roverLocation);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }
}
