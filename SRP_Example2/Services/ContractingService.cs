using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class ContractingService
    {
        public void MakeContract(Person p)
        {
            Console.WriteLine($"Creating new contract for {p.FirstName + " " + p.LastName} ");
        }
    }
}
