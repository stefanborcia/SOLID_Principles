using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(45.50);

            Square square = new Square(30.0);

            Rectangle rectangle = new Rectangle(20.50, 10.50);

            List<Shape> shapes = new List<Shape>()
            {
                circle,
                square,
                rectangle
            };

            AreaCalculator areaCalculator = new AreaCalculator(shapes);

            Console.WriteLine(areaCalculator.CalculateSum());

            Console.ReadKey();
        }


    }
}
