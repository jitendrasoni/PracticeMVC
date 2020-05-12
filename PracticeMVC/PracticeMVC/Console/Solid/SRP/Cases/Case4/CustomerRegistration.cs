using SRP.Cases.Case4.Right.Models;
using SRP.Cases.Case4.Right.Services;
using System;

namespace SRP.Cases.Case4
{
    public static class CustomerRegistration
    {

        public static void ExecuteAllVersion()
        {

            Console.WriteLine("Example 1 Start here --------------");
            ExecuteVersio4();

        }

        public static void ExecuteVersio4()
        {

            /// Option 1 Register Customer
            ICustomer customer = new Right.Models.Customer
            {
                EmailAddress = "test@test.com",
                Name = "First Customer!",
                Message = "Test message",
            };

            ICustomer staff = new Right.Models.Staff
            {
                EmailAddress = "test@test.com",
                Name = "First Staff!",
                Message = "Test message"
            };

           IRegister<ICustomer> registerCustomer = new Register<ICustomer>();
           registerCustomer.RegisterInstance(customer);
           registerCustomer.RegisterInstance(staff);



            ICustomerExtenstion customerExtenstion = new Right.Models.CustomerExtenstion
            {
                EmailAddress = "test@test.com",
                Name = "First Staff!",
                Message = "Test message",
                NameExtenstion ="extenstion Name"
            };
            IRegister<ICustomerExtenstion> registerCustomerExtenstion = new Register<ICustomerExtenstion>();
            registerCustomerExtenstion.RegisterInstance(customerExtenstion);
        }
    }
}
