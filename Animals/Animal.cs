using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz4Csharp.Animals
{
    internal class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Breed { get; set; }
        public DateTime BirthDate { get; set; }

        public Animal(string name, double weight, string breed, DateTime birthDate)
        {
            Name = name;
            Weight = weight;
            Breed = breed;
            BirthDate = birthDate;
        }
        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Вес: {Weight} кг, Порода: {Breed}, Дата рождения: {BirthDate:dd.MM.yyyy}";
        }

    }
}
