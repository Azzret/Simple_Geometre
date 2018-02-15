using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Square : Shape
    {
        public double Side1 { get; }

        public Square(double side1) 
        {
            Debug.Assert(side1 > 0, "side > 0");
            Side1 = side1;
            
        }

        public new void Print(Shape shape)
        {
            var square = (Square)shape;
            var area = square.Side1 * square.Side1;
            Console.WriteLine($"Square: area = {area}");
        }
    }
}
