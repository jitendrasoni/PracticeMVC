using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class Example2
    {
        public static void Singleton()
        {
            // Singleton for the log manager

            Log2 obj = new Log2();

            Console.WriteLine(obj.GetValue());
            obj = new Log2();

            Console.WriteLine(obj.GetValue());
            obj = new Log2();

            Console.WriteLine(obj.GetValue());

            Console.ReadLine();
        }
    }
    public class Log2
    {
        private static int value;
        public Log2()
        {
            value++;
        }

        public int GetValue()
        {
            return value;
        }
    }
}