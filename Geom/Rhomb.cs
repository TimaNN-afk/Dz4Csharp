using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Rhomb : GeometricShape // ромб
    {
        public double Side { get; set; }
        public double Corner { get; set; }

        public override double FindingSquare()
        {
            double rad = Corner * Math.PI / 180;
            return Side * Side * Math.Sin(rad);
        }
        public override double FindingPerimeter()
        {
            return 4 * Side;
        }
    }
}
