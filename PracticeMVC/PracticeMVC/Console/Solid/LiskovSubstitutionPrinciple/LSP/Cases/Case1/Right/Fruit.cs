using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Cases.Case1.Right
{
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
