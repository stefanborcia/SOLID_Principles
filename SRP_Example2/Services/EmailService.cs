using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class EmailService
    {
        public void SendMail(Person p)
        {
            Console.WriteLine($"The applicant {p.FirstName + " " + p.LastName} is hired!");
        }
    }
}
