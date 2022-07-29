using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTest
{
    internal class TruckСar : Car
    {
        private const decimal IncreasedFuelConsumption = 0.04m;
        /// <summary>
        /// максимальная загрузка в кг
        /// </summary>
        public decimal MaxLoadCapacity { get; set; }
        public TruckСar(decimal averageFuelConsumption, decimal fuelTankCapacity, decimal speed, decimal maxLoadCapacity) 
            : base(CarType.TruckСar, averageFuelConsumption, fuelTankCapacity, speed)
        {
            MaxLoadCapacity = maxLoadCapacity;
        }

        public override decimal PowerReserveStatus(decimal сargo)
        {
            if (CheckLoadCapacity(сargo))
                return base.CalculateCarCanPass() * (1 - (int)сargo / 200 * IncreasedFuelConsumption);
            else
                return decimal.Zero;

        }

        private bool CheckLoadCapacity(decimal сargo) 
        {
            if (сargo <= MaxLoadCapacity)
                return true;
            else
                return false;
        }
    }
}
