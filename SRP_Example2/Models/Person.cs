using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DesiredJob { get; set; }

        public int DesiredSalary { get; set; }

        public Person(string firstName, string lastName, string desiredJob, int desiredSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            DesiredJob = desiredJob;
            DesiredSalary = desiredSalary;
        }
    }
}
