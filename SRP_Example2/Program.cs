using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResource hr = new HumanResource(
                2000,
                new List<Person>()
                {
                    new Person("Stefan", "Iulian", "SD", 1500),
                    new Person("Robert", "Stefan", "QA", 1200),
                    new Person("Gabi", "Corlan", "Trainer", 3000)
                },
                new List<string>()
                {
                    "SD",
                    "Trainer",
                    "DevOps"
                });

            try
            {
                hr.Hire();
            }
            catch (JobNotAvailableException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SalaryTooHighException e)
            {
                Console.WriteLine(e.Message);
            }

           


            Console.ReadKey();
        }
    }
}
