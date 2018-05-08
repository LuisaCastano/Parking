using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Core.Model
{
    public abstract class Vehicle
    {
        public string Placa { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public abstract int GetAllVehicles(); 
    }
}
