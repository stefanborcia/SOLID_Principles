using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    public class Waiter : Employee
    {
        public Waiter(string firstName, string lastName, string department, int salary) : base(firstName, lastName, department, salary)
        {

        }
        public void ServeCustomers()
        {
            Console.WriteLine("Is serving the customers");
        }

        public void CleanTables()
        {
            Console.WriteLine("Is cleaning the tables");
        }

        public void TakeOrders()
        {
            Console.WriteLine("Is taking the orders");
        }

        public override void PerformDuties()
        { 
            TakeOrders();
            ServeCustomers();
            CleanTables();
        }
    }
}
