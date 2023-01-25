using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class RegistrationService
    {
        public void Register(Person p)
        {
            EmployeeDB.Add(p);
            Console.WriteLine($"{p.FirstName + " " + p.LastName} is successfully added to the employees data base.");
        }
    }
}
