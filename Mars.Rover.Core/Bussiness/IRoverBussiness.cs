using System;
using System.Collections.Generic;
using System.Text;
using Mars.Rover.Core.Model;

namespace Mars.Rover.Core.Bussiness
{
    public interface IRoverBussiness
    {
        Rovers CurrentRover(string location);
        void GetNewLocation(string redirection);

    }
}
