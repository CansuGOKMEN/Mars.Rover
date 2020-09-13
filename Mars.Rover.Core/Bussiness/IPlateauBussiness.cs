using Mars.Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Core.Bussiness
{
    public interface IPlateauBussiness
    {
        Plateau sizeParse(string plateauInput);
    }
}
