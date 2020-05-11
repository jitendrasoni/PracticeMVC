using SRP.Cases.Case4.Right.Models;
using System;
using System.Runtime.CompilerServices;

namespace SRP.Cases.Case4.Right.Services

{
    public class Register<T>  : IRegister<T>
        where T : ICustomer
     
    {
        public void RegisterInstance(T objCustomer)
        {
            Type typeParameterType = typeof(T);
            
            Console.Write($"Registration done for type {typeParameterType.Name}, Name {objCustomer.Name}");
            Console.ReadLine();
           
        }
    }
}
