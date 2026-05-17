using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Animals
{
    internal class Cat : Animal
    {
        private static Random random = new Random();
        public Cat(string name, double weight, string breed, DateTime birthDate) : base(name, weight, breed, birthDate) {}
        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo} (Котик)";
        }
        public bool CatchMouse()
        {
            int chance = random.Next(0, 101); 
            return chance > 50;
        }

    }
}
