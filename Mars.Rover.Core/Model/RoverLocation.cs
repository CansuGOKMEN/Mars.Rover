using System;
using System.Collections.Generic;
using System.Text;
using static Mars.Rover.Core.Components.Enums;

namespace Mars.Rover.Core.Model
{
    public class RoverLocation
    {
        /// <summary>
        /// Coordinates are assumed to be 0,0.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        public RoverLocation(int x = 0, int y = 0, Direction direction = Direction.N)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
    }
}
