using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;

namespace SimpleGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            var print = new Shape();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(3));
            shapes.Add(new Triangle(6, 5, 4));
            shapes.Add(new RightAngledTriangle(3, 4));
            shapes.Add(new Square(3));
            foreach (Shape shape in shapes)
                //Console.WriteLine(shape);
               ShapePrinter.Print(shape);

                


            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}

