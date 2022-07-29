using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTest
{
    public class PassengerCar : Car
    {
        private const decimal IncreasedFuelConsumption = 0.06m;
        public int MaxCountPassenger { get; set; }
        public PassengerCar(decimal averageFuelConsumption, decimal fuelTankCapacity, decimal speed, int maxCountPassenger) 
            : base(CarType.PassengerCar, averageFuelConsumption, fuelTankCapacity, speed)
        {
            MaxCountPassenger = maxCountPassenger;
        }

        public override decimal PowerReserveStatus(decimal сargo)
        {
            if (CheckCountPassenger((int)сargo))
                return base.CalculateCarCanPass() * ( 1 - (int)сargo * IncreasedFuelConsumption);
            else
                return decimal.Zero;
        }

        private bool CheckCountPassenger(int countPassenger)
        {
            if (countPassenger <= MaxCountPassenger)
                return true;
            else
                return false;
        }
    }
}
