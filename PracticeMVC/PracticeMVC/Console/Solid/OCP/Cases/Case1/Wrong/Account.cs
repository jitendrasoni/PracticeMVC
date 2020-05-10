using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Cases.Case1.Wrong
{
    public class Account
    {
        public decimal Interest { get; set; }
        public string Balance { get; set; }
        public string CalculateInterest(AccountType accType)
        {

            if (accType == AccountType.Saving) // savings
            {
                Console.WriteLine($"{accType} Account Calculated");
                Console.ReadLine();
            }
            else if (accType == AccountType.Salary) // salary savings
            {
                Console.WriteLine($"{accType} Account Calculated");
                Console.ReadLine();
            }
            else if (accType == AccountType.Corporate) // Corporate
            {
                Console.WriteLine($"{accType} Account Calculated");
                Console.ReadLine();
            }

            return accType.ToString(); 
        }
    }
  public  enum AccountType
    {
        Saving,
        Salary,
        Corporate
    }
}
