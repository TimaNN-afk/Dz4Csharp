using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Transport
{
    internal class Bus : PublicTransport
    {
        private double _fuelTankCapacity;
        private const double _fuelConsumptionPer25km = 20.0;
        private const double _distanceForConsumption = 25.0;

        public Bus(int number, int capacity, double currentSpeed, double fuelTankCapacity) : base(number, capacity, currentSpeed)
        {
            if (fuelTankCapacity <= 0)
            {
                Console.WriteLine("Вместимость бензобака должна быть положительной");
            }
            else
            {
                _fuelTankCapacity = fuelTankCapacity;
            }
        }

        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo}, Тип: Автобус, Бензобак: {_fuelTankCapacity} л";
        }

        public double GetMaxDistance()
        {
            double consumptionPerKm = _fuelConsumptionPer25km / _distanceForConsumption;
            return _fuelTankCapacity / consumptionPerKm;
        }
    }
}
