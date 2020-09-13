using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Core.Model
{
    public class Rovers
    {
        public Rovers(RoverLocation roverLocation)
        {
            RoverLocation = roverLocation;
        }

        public string Name { get; set; } = "StarShip";
        public RoverLocation RoverLocation { get; set; }
    }
}
