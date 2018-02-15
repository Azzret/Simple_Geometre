using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Произвольный треугольник
    /// </summary>
    public class Triangle : Shape
    {
        // Длины сторон треугольника
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Debug.Assert(side1 > 0, "side1 > 0");
            Debug.Assert(side2 > 0, "side2 > 0");
            Debug.Assert(side3 > 0, "side3 > 0");
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public new void Print(Shape shape)
        {
            var triangle = (Triangle)shape;
            var p = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2;
            var area = Math.Sqrt(p * (p - triangle.Side1) * (p - triangle.Side2) * (p - triangle.Side3));
            Console.WriteLine($"Triangle: area = {area}");
        }
    }
}
