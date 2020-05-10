using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Cases.Case1.Right
{
    class Saving : AccountBase
    {
        public override string CalculateInterest()
        {
            Console.WriteLine($"{this.GetType().Name} Account Calculated");
            Console.ReadLine();
            return this.GetType().Name;
        }
    }
}
