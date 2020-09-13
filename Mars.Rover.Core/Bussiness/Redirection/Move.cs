using Mars.Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static Mars.Rover.Core.Components.Enums;

namespace Mars.Rover.Core.Bussiness.Redirection
{
    public class Move : IExplore
    {
        public void Explore(RoverLocation roverLocation)
        {
            switch (roverLocation.Direction)
            {
                case Direction.N:
                    roverLocation.Y = roverLocation.Y + 1;
                    break;
                case Direction.E:
                    roverLocation.X = roverLocation.X + 1;
                    break;
                case Direction.S:
                    roverLocation.Y = roverLocation.Y - 1;
                    break;
                case Direction.W:
                    roverLocation.X = roverLocation.X - 1;
                    break;
            }
        }
    }
}
