using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example2
{
    public class Circle : Shape
    {
        public double Radious { get; set; }

        public Circle(double radious)
        {
            Radious = radious;
        }

        public override double GetShapeArea()
        {
            return Math.PI * Radious * Radious;
        }
    }
}
