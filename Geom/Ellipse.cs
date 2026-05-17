using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Ellipse : GeometricShape // Элипс
    {
        public double SmallAxis { get; set; }
        public double BigAxis { get; set; }

        public Ellipse(double smallAxis, double bigAxis)
        { 
            SmallAxis = smallAxis;
            BigAxis = bigAxis;
        }

        public override double FindingSquare()
        {
            return Math.PI * SmallAxis * BigAxis;
        }

        public override double FindingPerimeter()
        {
            return 2 * Math.Sqrt((Math.Pow(SmallAxis, 2) + Math.Pow(BigAxis, 2)) / 2);
        }
    }
}
