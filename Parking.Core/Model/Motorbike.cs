using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Core.Model
{
    public class Motorbike : Vehicle
    {
        public Boolean IsAltoCilindraje { get; set; }
        public override int GetAllVehicles()
        {
            return 4;
        }
    }
}
