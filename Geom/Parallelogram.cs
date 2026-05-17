using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Parallelogram : GeometricShape // Параллелограм
    {
        public double A { get; set; }
        public double B { get; set; }
        public double angleSize { get; set; }

        public Parallelogram(double a, double b, double height)
        {
            A = a;
            B = b;
            angleSize = height;
        }
        public override double FindingSquare()
        {
            double rad = angleSize * Math.PI / 180;
            return A * B * Math.Sin(rad);
        }
        public override double FindingPerimeter()
        {
            return 2 * (A + B);
        }
    }
}
