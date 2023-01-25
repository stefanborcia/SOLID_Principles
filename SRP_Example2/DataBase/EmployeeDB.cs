using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class EmployeeDB
    {
        public static List<Person> employees = new List<Person>();

        public static void Add(Person person)
        {
            employees.Add(person);
        }
    }
}
