using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTest
{
    internal class SportCar : Car
    {
        public SportCar(decimal averageFuelConsumption, decimal fuelTankCapacity, decimal speed) : base(CarType.SportCar, averageFuelConsumption, fuelTankCapacity, speed)
        {
        }

        public override decimal PowerReserveStatus(decimal сargo)
        {
            return decimal.Zero;
        }
    }
}
