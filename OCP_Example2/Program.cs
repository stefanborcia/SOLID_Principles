using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(2.0,3.0);

            Shape square = new Square(4);

            Shape circle = new Circle(6);

            Console.WriteLine("An application which calculate the area of a shape\n");

            Console.WriteLine($"Area of a rectangle is: {rectangle.GetShapeArea()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Area of a square is: {square.GetShapeArea()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Area of a circle is: {circle.GetShapeArea()}");



            Console.ReadKey();
        }
    }
}
