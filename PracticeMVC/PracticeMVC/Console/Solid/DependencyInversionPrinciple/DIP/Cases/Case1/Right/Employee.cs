using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Cases.Case1.Right
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }

    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }
    public enum Gender
    {
        Male,
        Female
    }
}
