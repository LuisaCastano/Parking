using System;
using System.Collections.Generic;
using System.Text;
using Parking.Core.Model;

namespace Parking.Core
{
    interface IParkingManager
    {
        Tuple<bool, string> ReceiveVehicle(Vehicle vehicle);
        int CollectParking(Vehicle vehicle);

    }
}
