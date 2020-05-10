using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Cases.Case1
{
    public static class AccountRegistration
    {
        public static void ExecuteWrongVersion()
        {
            Wrong.Account objWrong = new Wrong.Account();
            objWrong.CalculateInterest(Wrong.AccountType.Corporate);
            objWrong.CalculateInterest(Wrong.AccountType.Salary);
            objWrong.CalculateInterest(Wrong.AccountType.Saving);
        }

        public static void ExecutVersion1()
        {
            Right.Salary objAccountSalary = new Right.Salary();
            objAccountSalary.CalculateInterest();
            Right.Saving objAccountSaving = new Right.Saving();
            objAccountSaving.CalculateInterest();
            Right.Corporate objAccountCorporate = new Right.Corporate();
            objAccountCorporate.CalculateInterest();
        }

        public static void ExecutVersion2()
        {
            Right.Salary objAccountSalary = new Right.Salary();
            objAccountSalary.CalculateInterest();
            Right.Saving objAccountSaving = new Right.Saving();
            objAccountSaving.CalculateInterest();
            Right.Corporate objAccountCorporate = new Right.Corporate();
            objAccountCorporate.CalculateInterest();
        }
    }
}
