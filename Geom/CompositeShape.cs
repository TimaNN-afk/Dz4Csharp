using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4Csharp.Geom
{
    internal class CompositeShape : GeometricShape
    {
        private List<GeometricShape> shapes = new List<GeometricShape>();

        public void AddShape(GeometricShape shape)
        {
            shapes.Add(shape);
        }
        public void RemoveShape(GeometricShape shape)
        {
            shapes.Remove(shape);
        }

        public override double FindingSquare()
        {
            double total = 0;
            foreach (var shape in shapes)
                total += shape.FindingSquare();
            return total;
        }

        public override double FindingPerimeter()
        {
            double total = 0;
            foreach (var shape in shapes)
                total += shape.FindingPerimeter();
            return total;
        }

    }
}
