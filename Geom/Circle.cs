using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Circle :  GeometricShape // круг
    {
        public double Radius {  get; set; }
        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double FindingSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double FindingPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
