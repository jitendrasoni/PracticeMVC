using System;

namespace SRP.Cases.Case1
{
    public static class CustomerRegistration
    {

        public static void ExecuteAllVersion()
        {
            Console.WriteLine("Example 1 Start here --------------");
            ExecuteWrongVersion();
            Console.WriteLine("Example 2 Start here --------------");
            ExecutVersion1();

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

        public static void ExecutVersion1()
        {
            Right.Registration registerCustomer = new Right.Registration
            {
                EmailAddress = "test@test.com",
                Name = "First Customer!",
                Message = "Test message"
            };
            registerCustomer.Register();
        }
    }
}
