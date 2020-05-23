using System;

namespace SRP.Wrong
{

    public class Registration
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }

        public void Register()
        {
            ValidateEmailAddress();
            Console.WriteLine($"I'm calling from Class {this.GetType().Name}");
            Console.WriteLine($"Successfully Registered {Name}");
            SendEmailMessage();
            Console.ReadLine();
        }

        public void SendEmailMessage()
        {
            Console.WriteLine($"I'm calling from Class {this.GetType().Name}");
            Console.WriteLine($"Email succesfully sent to {EmailAddress}");
            Console.ReadLine();
        }

        public void ValidateEmailAddress()
        {
            Console.WriteLine($"I'm calling from Class {this.GetType().Name}");
            Console.WriteLine($"Validation {EmailAddress?.Contains("@")}");

        }
    }
}
