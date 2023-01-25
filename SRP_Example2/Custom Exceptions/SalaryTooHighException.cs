using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class SalaryTooHighException : SystemException
    {
        public string Message { get; set; } = "We're sorry, but the desire salary is not related to our budget.";
    }
}
