using SRP.Cases.Case3.Right.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Cases.Case3.Right.Services

{
    public class Notification : INotification
    {
        public void SendNotification(ICustomer objCustomer)
        {
            Console.WriteLine("Notification send");
        }
    }
}
