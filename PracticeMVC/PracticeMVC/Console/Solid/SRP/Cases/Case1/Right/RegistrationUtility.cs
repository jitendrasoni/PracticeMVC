using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Cases.Case1.Right
{
    class RegistrationUtility
    {

        public void ValidateEmailAddress(string EmailAddress)
        {
            Console.WriteLine($"I'm calling from Class {this.GetType().Name}");
            Console.WriteLine($"Validation {EmailAddress?.Contains("@")}");

        }

        public void SendEmailMessage(string EmailAddress)
        {
            Console.WriteLine($"I'm calling from Class {this.GetType().Name}");
            Console.WriteLine($"Email succesfully sent to {EmailAddress}");
            Console.ReadLine();
        }

      
    }
}
