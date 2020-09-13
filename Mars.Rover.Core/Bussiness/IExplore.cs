using Mars.Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Core.Bussiness
{
    public interface IExplore
    {
        /// <summary>
        /// instructions telling the rover how to explore the plateau.
        /// </summary>
        /// <param name="rover"></param>
        void Explore(RoverLocation roverLocation);
    }
}
