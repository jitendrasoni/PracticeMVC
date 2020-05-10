using SRP.Cases.Case2.Right.Models;
using System;

namespace SRP.Cases.Case2.Right.Services
{
    public class Register : IRegister
    {
        public void RegisterInstance(ICustomer objCustomer)
        {
            Console.Write("Save Register");
        }
    }
}
