using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Principle
{
    public class AreaCalculator
    {
        public List<Shape> Shapes { get; set; }

        public AreaCalculator(List<Shape> shapes)
        {
            Shapes = shapes;
        }

        public  double CalculateSum()
        {
            double sum = 0;
            foreach (var shape in Shapes)
            {
                sum += shape.GetArea(); 
            }
            return sum; 
        }
    }
}
