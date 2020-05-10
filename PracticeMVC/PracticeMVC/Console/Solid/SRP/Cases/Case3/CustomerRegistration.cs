using SRP.Cases.Case3.Right.Models;
using SRP.Cases.Case3.Right.Services;
using System;

namespace SRP.Cases.Case3
{
    public static class CustomerRegistration
    {

        public static void ExecuteAllVersion()
        {

            Console.WriteLine("Example 1 Start here --------------");
            ExecuteVersio3();

        }



        public static void ExecuteVersio3()
        {
            // Interface defined
            // Separate service for Registration
            // Separate service for Email Notification

            Customer customer = new Right.Models.Customer
            {
                EmailAddress = "test@test.com",
                Name = "First Customer!",
                Message = "Test message"
            };

            Staff staff = new Right.Models.Staff
            {
                EmailAddress = "test@test.com",
                Name = "First Customer!",
                Message = "Test message"
            };

            IRegister<Customer> registerCustomer = new RegisterCustomer<Customer>();
            registerCustomer.RegisterInstance(customer);

            IRegister<Staff> registerStaff = new RegisterCustomer<Staff>();
            registerStaff.RegisterInstance(staff);

            INotification notification = new Notification();
            notification.SendNotification(customer);

        }
    }
}
