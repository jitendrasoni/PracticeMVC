using SRP.Cases.Case1.Right;
using System;

namespace SRP.Cases.Case1.Right
{

    public class Registration
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }

        public void Register()
        {
            RegistrationUtility registerUtility = new RegistrationUtility();
            registerUtility.ValidateEmailAddress(EmailAddress);
            Console.WriteLine($"I'm calling from Class {this.GetType().Name}");
            Console.WriteLine($"Successfully Registered {Name}");
            registerUtility.SendEmailMessage(Message);
            Console.ReadLine();
        }

     
    }
}
