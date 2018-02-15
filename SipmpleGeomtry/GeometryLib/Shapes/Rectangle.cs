using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Rectangle:Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
         }
        public override string Print() {
            Area = Side1 * Side2;
            return String.Format("Rectangle: sides: {0} {1}, area = {2}",
                Side1, Side2, Area);
        }
    }
}
