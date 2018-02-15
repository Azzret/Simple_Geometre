using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }

          public new void Print(Shape shape)
            {
                var circle = (Circle)shape;
        var area = circle.Radius * circle.Radius * Math.PI;
        Console.WriteLine($"Circle: radius = {circle.Radius}, area = {area}");
            }
    }
}
