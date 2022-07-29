using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTest
{
    public enum CarType
    {
        PassengerCar,
        TruckСar,
        SportCar
    }
    public abstract class Car
    {   /// <summary>
        /// тип автомобиля
        /// </summary>
        public CarType CarType { get; set; }
        /// <summary>
        /// Среднее потребление топлива на 100 км
        /// </summary>
        public decimal AverageFuelConsumption { get; set; }
        /// <summary>
        /// Емкость топливного бака
        /// </summary>
        public decimal FuelTankCapacity { get; set; }
        /// <summary>
        /// Скорость в км/ч
        /// </summary>
        public decimal Speed { get; set; }
        public Car(CarType carType, decimal averageFuelConsumption, decimal fuelTankCapacity, decimal speed)
        {
            CarType = carType;
            AverageFuelConsumption = averageFuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            Speed = speed;
        }
        /// <summary>
        /// Метод вычисляет сколько автомобиль может проехать на полном баке топлива
        /// или на остаточном количестве топлива в баке на данный момент.
        /// </summary>
        /// <value>При полном баке remainingFuel = 0 </value>
        /// <returns>Пройденное растояние в км</returns>
        /// <param name="remainingFuel">Оставшееся топливо</param>
        public decimal CalculateCarCanPass(decimal remainingFuel = 0) 
        {
            if (remainingFuel == 0)
                remainingFuel = FuelTankCapacity;
            return remainingFuel / AverageFuelConsumption * 100;
           // Console.WriteLine($"Автомобиль может проехать {remainingFuel / AverageFuelConsumption * 100} км");            
        }
        /// <summary>
        /// Метод для отображения текущей информации о состоянии запаса хода 
        /// в зависимости от пассажиров и груза.
        /// </summary>
        public abstract decimal PowerReserveStatus(decimal сargo);

        /// <summary>
        /// Метод, который на основе параметров количества топлива и 
        /// заданного расстояния вычисляет за сколько автомобиль его преодолеет
        /// </summary>
        /// <value>При полном баке remainingFuel = 0 </value>
        /// <returns>Пройденное растояние в км</returns>
        /// <param name="remainingFuel"></param>
        public string CalculateDistanceTime(decimal distance, decimal remainingFuel = 0) 
        {          
            var carCanPass = CalculateCarCanPass(remainingFuel);
            if (carCanPass >= distance)
                return $" Машина проедет за {CalculateTime(distance)} часа";
            else 
            {
                var countGasStation = distance / carCanPass;
                return $" Машина проедет за {CalculateTime(distance)} часа, понадобится {Decimal.Ceiling(countGasStation)} дозаправок";
            }

        }

        private decimal CalculateTime(decimal distance) 
        {
            return distance / Speed;
        }
    }
}
