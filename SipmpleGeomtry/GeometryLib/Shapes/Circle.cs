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
    public class Circle : Shape,IPrintable
    {
        public double Radius { get;set; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }
        public override string  Print(){
            Area=Math.Pow(Radius,2)*Math.PI;
            return String.Format("Circle: radius = {0}, area = {1}",
               Radius,Area );
         }
    }
}
