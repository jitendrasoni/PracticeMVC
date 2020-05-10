using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Cases.Case3.Right.Models
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
    }
}
