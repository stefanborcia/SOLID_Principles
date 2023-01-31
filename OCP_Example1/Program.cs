using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // A class must be Open for extension, but Closed for modification

            Employee chef = new Chef("stefan", "iulian", "chefs", 2000);

            Employee waiter = new Waiter("robert", "stefan", "waiters", 500);

            Employee security = new Security("gabriel", "corlan", "security's", 1500);

            Employee janitor = new Janitor("andrea", "salae", "janitors", 250);

            RestaurantManager employe = new RestaurantManager();

            employe.CallEmployee(chef);
            Console.WriteLine(chef);
            Console.WriteLine("-------------------------------------");
            employe.CallEmployee(waiter);
            Console.WriteLine(waiter);
            Console.WriteLine("-------------------------------------");
            employe.CallEmployee(security);
            Console.WriteLine(security);
            Console.WriteLine("-------------------------------------");
            employe.CallEmployee(janitor);
            Console.WriteLine(janitor);

            Console.ReadKey();
        }
    }
}
