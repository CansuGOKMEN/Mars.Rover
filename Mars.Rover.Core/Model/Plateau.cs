using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Mars.Rover.Core.Model
{
    public class Plateau
    {
        public Plateau(Size size)
        {
            Size = size;
        }

        public string Name { get; set; } = "Mars";
        public Size Size { get; set; }
    }
}
