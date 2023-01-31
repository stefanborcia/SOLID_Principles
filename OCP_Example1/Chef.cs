using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    public  class Chef : Employee
    {
        public Chef(string firstName, string lastName, string department, int salary) : base(firstName, lastName, department, salary) { }

        public void CookFood()
        {
            Console.WriteLine("Cooking food");
        }

        public void DesignPlate()
        {
            Console.WriteLine("Designing the plates");
        }

        public void CutMeatChops()
        {
            Console.WriteLine("Cutting the meat");
        }

        public override void PerformDuties()
        {
            CookFood();
            DesignPlate();
            CutMeatChops();
        }
    }
}
