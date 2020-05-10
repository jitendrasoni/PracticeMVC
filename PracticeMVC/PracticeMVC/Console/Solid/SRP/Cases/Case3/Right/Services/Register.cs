using SRP.Cases.Case3.Right.Models;
using System;
using System.Runtime.CompilerServices;

namespace SRP.Cases.Case3.Right.Services

{
    public class RegisterCustomer<T>  : IRegister<T> where T : ICustomer
    {
        public void RegisterInstance(T objCustomer)
        {
            Console.Write($"Registration done for {this.GetType().Name}");
        }
    }

}
