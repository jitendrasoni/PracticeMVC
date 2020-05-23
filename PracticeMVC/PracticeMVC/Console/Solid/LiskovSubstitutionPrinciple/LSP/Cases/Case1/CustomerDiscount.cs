using LSP.Cases.Case1.Right;
using LSP.Cases.Case1.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apple = LSP.Cases.Case1.Right.Apple;
using AppleWrong = LSP.Cases.Case1.Wrong.Apple;
using Orange = LSP.Cases.Case1.Right.Orange;
using OrangeWrong = LSP.Cases.Case1.Wrong.Orange;
namespace LSP.Cases.Case1
{
    public static class CustomerDiscount
    {
        public static void ExecuteWrong()
        {
            AppleWrong apple = new OrangeWrong();
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
