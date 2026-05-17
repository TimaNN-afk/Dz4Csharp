using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Trapezoid : GeometricShape // трапеция
    {
        public double BaseA {  get; set; }
        public double BaseB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public double Height {  get; set; }

        public Trapezoid(double baseA, double baseB, double sideC, double sideD)
        {
            BaseA = baseA;
            BaseB = baseB;
            SideC = sideC;
            SideD = sideD;
        }
        public override double FindingSquare()
        { 
            return (BaseA + BaseB) / 2 * Height;
        }
        public override double FindingPerimeter()
        {
            return BaseA + BaseB + SideC + SideD;
        }
    }
}
