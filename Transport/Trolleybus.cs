using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Transport
{
    internal class Trolleybus : PublicTransport
    {
        private double _batteryCapacity; // ёмкость аккумулятора в кВт·ч
        private const double _powerConsumptionPer70km = 200.0; // 200 кВт·ч на 70 км
        private const double _distanceForConsumption = 70.0;   // 70 км

        public Trolleybus(int number, int capacity, double currentSpeed, double batteryCapacity) : base(number, capacity, currentSpeed)
        {
            if (batteryCapacity <= 0)
            {
                Console.WriteLine("Ёмкость аккумулятора должна быть положительной");
            }
            else
            {
                _batteryCapacity = batteryCapacity;
            }
        }

        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo}, Тип: Троллейбус, Аккумулятор: {_batteryCapacity} кВт·ч";
        }

        public double GetMaxDistance()
        {
            double consumptionPerKm = _powerConsumptionPer70km / _distanceForConsumption;
            return _batteryCapacity / consumptionPerKm;
        }
    }
}
