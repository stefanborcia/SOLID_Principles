using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example2
{
    public class AreaCalculator
    {
        public double GetShapeArea(Shape shape)
        {
           return shape.GetShapeArea();
        }
    }
}
