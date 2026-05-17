using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp
{
    internal class Parrot : Animal
    {
        public Parrot(string name, double weight, string breed, DateTime birthDate) : base(name, weight, breed, birthDate) {}
        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo} (Попугайчик)";
        }
        public void Sing()
        {
            Console.WriteLine($"{Name} поёт: Чирик-чирик!");
        }
    }
}
