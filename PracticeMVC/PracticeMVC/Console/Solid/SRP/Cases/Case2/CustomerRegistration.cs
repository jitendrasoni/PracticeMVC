using SRP.Cases.Case2.Right.Models;
using SRP.Cases.Case2.Right.Services;
using System;

namespace SRP.Cases.Case2
{
    public static class CustomerRegistration
    {

        public static void ExecuteAllVersion()
        {
            Console.WriteLine("Example 1 Start here --------------");
            ExecuteWrongVersion();
            Console.WriteLine("Example 2 Start here --------------");
            ExecuteVersio2();

        }

        public static void ExecuteWrongVersion()
        {
            Wrong.Registration registerCustomer = new Wrong.Registration
            {
                EmailAddress = "test@test.com",
                Name = "First Customer!",
                Message = "Test message"
            };
            registerCustomer.Register();
        }

        public static void ExecuteVersio2()
        {
            // Interface defined
            // Separate service for Registration
            // Separate service for Email Notification

            ICustomer customer = new Right.Models.Customer
            {
                EmailAddress = "test@test.com",
                Name = "First Customer!",
                Message = "Test message"
            };

            IRegister register = new Register();
            register.RegisterInstance(customer);

            INotification notification = new Notification();
            notification.SendNotification(customer);

        }

    }
}
