using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Cases.Case1
{
   public static class PrinterExample
    {
        public static void ExecuteWrongVersion()
        {

            Case1.Wrong.IPrinterTasks objLaserJetPrinter = new
                Case1.Wrong.HPLaserJetPrinter();
            objLaserJetPrinter.Print("Print");
            objLaserJetPrinter.Print("Fax");

        }

        public static void ExecutVersion1()
        {

            Case1.Right.IPrinterTasks objLaserJetPrinter = new
            Case1.Right.HPLaserJetPrinter();
            objLaserJetPrinter.Print("Fax");

            Case1.Right.IFaxTasks objFaxTask = new
          Case1.Right.HPLaserJetPrinter();
            objFaxTask.Fax("Fax");

        }
    }
}
