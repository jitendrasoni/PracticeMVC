using SRP.Cases.Case3.Right.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Cases.Case4.Right.Services

{
    public class Notification<T> : INotification<T>
       
    {
        public void SendNotification(ICustomer objCustomer)
        {
            Console.WriteLine("Notification send");
        }
    }
}
