using System;
using System.Collections.Generic;
using System.Text;
using Parking.Core.Model;

namespace Parking.Core
{
    public class ParkingManager : IParkingManager
    {
        public int CollectParking(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Tuple<bool, string> ReceiveVehicle(Vehicle vehicle)
        {
            return new Tuple<bool, string>(true, "");
        }
    }
}
