using Mars.Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Mars.Rover.Core.Bussiness
{
    public class PlateauBussiness : IPlateauBussiness
    {
        public Plateau sizeParse(string plateauInput)
        {
            if (string.IsNullOrEmpty(plateauInput))
            {
                Console.WriteLine("Captan is coordinaties doesnt match... Please some diffrent coordinaties.");
                return null;
            }

            string[] plateauSize = plateauInput.Split(' ');
            if (plateauSize.Length != 2)
            {
                Console.WriteLine("Okey captan. u're so close..Please try again");
                return null;
            }

            int width = Convert.ToInt32(plateauSize[0]);
            int height = Convert.ToInt32(plateauSize[1]);
            Size size = new Size(width, height);

            Plateau plateau = new Plateau(size);
            return plateau;
        }
    }
}
