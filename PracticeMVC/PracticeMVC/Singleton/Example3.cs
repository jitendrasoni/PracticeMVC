using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class Example3
    {
        public static void Singleton()
        {
            Log3 obj = Log3.GetInstance();

            Log3 obj1 = Log3.GetInstance();

            if (obj == obj1)
            {
                Console.WriteLine("Singleton is working, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton got fail, variables contain different instances.");
            }
            Console.ReadLine();
        }
    }
    public class Log3
    {
        private Log3()
        {

        }

        private static Log3 _instance;

        public static Log3 GetInstance()
        {
           if (_instance== null) _instance = new Log3();
               return _instance;
        }

    }
}