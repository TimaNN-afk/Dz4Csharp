using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Quadrate : GeometricShape // квадрат
    {
        public double Side { get; set; }
        public Quadrate(double side)
        {
            Side = side;
        }
        public override double FindingSquare()
        {
            return Side * Side;
        }
        public override double FindingPerimeter()
        {
            return 4 * Side;
        }
    }
}
