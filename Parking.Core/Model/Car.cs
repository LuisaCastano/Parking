using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Core.Model
{
    public class Car : Vehicle
    {
        public override int GetCountVehicles()
        {
            return 20;
        }
    }
}
