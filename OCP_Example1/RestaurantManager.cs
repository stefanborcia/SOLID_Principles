using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Example1
{
    public class RestaurantManager
    {
        // This method should call any employee to do his job
        public void CallEmployee(Employee employee)
        {
            employee.PerformDuties();
        }
    }
}
