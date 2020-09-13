using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Core.Components
{
    public class Enums
    {
        public enum Direction
        {
            N,
            W,
            E,
            S
        }

        public enum MovementDirection
        {
            Right = 'R',
            Left = 'L',
            Move = 'M'
        }
    }
}
