using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class JobNotAvailableException : SystemException
    {
        private string message = "We're sorry, but the desired job is not available.";
        public override string Message
        {
            get
            {
                return message;
            }
            
        } 
    }
}
