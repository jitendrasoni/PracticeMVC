using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment - Object instantiation 
            //Example1.Singleton();
            // Result - 1,1,1

            // Comment -  Static member
           // Example2.Singleton();
            // Result - 1,2,3

            // Comment -  Static member
            Example3.Singleton();
            // Result -  Test case pass
        }
    }
}
