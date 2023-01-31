using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine($"Area of rectangle is: {rectangle.GetShapeArea()}");
            Console.WriteLine($"Area of square is: {square.GetShapeArea()}");

            Console.ReadKey();
        }
    }
}
