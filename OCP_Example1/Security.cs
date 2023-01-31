using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    public class Security : Employee
    {
        public Security(string firstName, string lastName, string department, int salary) : base(firstName, lastName, department, salary) { }

        public void GuardDoor()
        {
            Console.WriteLine("Look at the door");
        }

        public void CheckReservation()
        {
            Console.WriteLine("Checking the reservation");
        }

        public override void PerformDuties()
        {
            GuardDoor();
            CheckReservation();
        }
    }
}
