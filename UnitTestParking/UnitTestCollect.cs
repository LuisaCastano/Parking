using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parking.Core;
using Parking.Core.Model;

namespace UnitTestParking
{
    [TestClass]
    public class UnitTestParkingManager
    {
        private readonly ParkingManager _parkingManager;
        
        public UnitTestParkingManager()
        {
            _parkingManager = new ParkingManager();
        }

        [TestMethod]
        public void TestReciveCar()
        {
            var car = new Car()
            {
                Placa = "III222"
            };
            var result = _parkingManager.ReceiveVehicle(car);
            Assert.IsTrue(result.Item1);
        }

        [TestMethod]
        public void TestReciveMotorbike()
        {
            var motorbike = new Motorbike()
            {
                Placa = "III222",
                IsAltoCilindraje = false
            };
            var result = _parkingManager.ReceiveVehicle(motorbike);
            Assert.IsTrue(result.Item1);
        }
    }
}
