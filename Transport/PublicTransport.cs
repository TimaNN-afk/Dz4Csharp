using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dz4Csharp.Transport
{
    internal class PublicTransport
    {
        public int Number {  get; set; }
        public int Capacity { get; set; }
        public double CurrentSpeed { get; set; }

        public PublicTransport(int number, int capacity, double currentSpeed)
        {
            Number = number;
            Capacity = capacity;
            CurrentSpeed = currentSpeed;
        }
        public virtual string GetInfo()
        {
            return $"Номер: {Number}, Вместимость: {Capacity} пасс., Текущая скорость: {CurrentSpeed} км/ч";
        }
    }
}
