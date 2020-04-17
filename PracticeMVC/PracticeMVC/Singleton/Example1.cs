using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class Example1
    {
      public  static void Singleton()
        {
            // Singleton for the log manager

            Log obj = new Log();

            Console.WriteLine(obj.GetValue());
            obj = new Log();

            Console.WriteLine(obj.GetValue());
            obj = new Log();

            Console.WriteLine(obj.GetValue());

            Console.ReadLine();
        }
    }
    public class Log
    {
        private  int value;
        public Log()
        {
            value++;
        }

        public int GetValue()
        {
            return value;
        }
    }
}
