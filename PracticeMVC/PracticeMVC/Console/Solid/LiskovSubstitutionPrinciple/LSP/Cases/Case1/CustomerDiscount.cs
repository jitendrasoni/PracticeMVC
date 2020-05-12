using LSP.Cases.Case1.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Cases.Case1
{
    public static class CustomerDiscount
    {
        public static void ExecuteWrong()
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }

        public static void ExecuteRightVersion()
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
