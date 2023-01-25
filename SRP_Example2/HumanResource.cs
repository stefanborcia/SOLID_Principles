using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example2
{
    public class HumanResource
    {
        private EmailService emailService = new EmailService();  // - composition
        private ContractingService contracting = new ContractingService(); // - composition
        private RegistrationService registration = new RegistrationService(); // - composition
        public int Budget { get; set; }
        public List<Person> Applicants { get; set; }

        public List<string> AvailableJobs { get; set; }

        public HumanResource(int budget, List<Person> applicants, List<string> availableJobs)
        {
            Budget = budget;
            Applicants = applicants;
            AvailableJobs = availableJobs;
        }

        public void Hire()
        {
            foreach (var aplicant in Applicants)
            {
                if (aplicant.DesiredSalary <= Budget && AvailableJobs.Contains(aplicant.DesiredJob))
                {
                    emailService.SendMail(aplicant);
                    registration.Register(aplicant);
                    contracting.MakeContract(aplicant);
                }
                else if (!AvailableJobs.Contains(aplicant.DesiredJob))
                {
                    throw new JobNotAvailableException();
                }
                else if (aplicant.DesiredSalary > Budget)
                {
                    throw new SalaryTooHighException();
                }
            }
        }





    }
}
