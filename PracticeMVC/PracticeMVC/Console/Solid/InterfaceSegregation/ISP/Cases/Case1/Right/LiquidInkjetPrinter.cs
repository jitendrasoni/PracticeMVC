using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Cases.Case1.Right
{
    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
