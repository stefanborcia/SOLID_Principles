using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    public class Janitor : Employee
    {
        public Janitor(string firstName, string lastName, string department, int salary) : base(firstName, lastName, department, salary)
        {

        }

        public void Clean()
        {
            Console.WriteLine("Is cleaning");
        }

        public override void PerformDuties()
        {
            Clean();
        }
    }
}
