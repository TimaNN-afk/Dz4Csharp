using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Triangle : GeometricShape // Треугольник
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a; 
            B = b;
            C = c;
        }
        public override double FindingSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override double FindingPerimeter()
        {
            return A + B + B;
        }

    }
}
