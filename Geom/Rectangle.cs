using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class Rectangle : GeometricShape // прямоугольниик
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        }
        public override double FindingSquare()
        {
            return Width * Height;
        }
        public override double FindingPerimeter()
        {
            return 2 * (Width + Height);
        }
    }   
}
