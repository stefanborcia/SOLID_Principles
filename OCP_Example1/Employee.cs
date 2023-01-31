using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    public abstract class Employee
    {
        private static int idCounter;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public Employee(string firstName, string lastName, string department, int salary)
        {
            ID = ++idCounter;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = salary;
        }

        public abstract void PerformDuties();

        public override string ToString()
        {
            return
                $"The Employee with Id: {ID}, First name: {FirstName} , Last name: {LastName}, the Deparment: {Department}, has a salary of {Salary}";
        }
    }
}
