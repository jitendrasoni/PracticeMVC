using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://code-maze.com/dependency-inversion-principle/
            //https://code-maze.com/liskov-substitution-principle/
            // Reference - https://dotnettutorials.net/lesson/dependency-inversion-principle/
            ///The Dependency Inversion Principle (DIP) states that high-level 
            ///modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.

            // As per the Dependency Inversion Principle definition, “a high-level module should not depend on low-level modules.Both should depend on the abstraction”.

            //The second rule of the Dependency Inversion Principle state that “Abstractions should not depend on details. Details should depend on abstractions”.


            // What is Abstraction ?
            //In simple words, we can say that Abstraction means something which is non - concrete.So, abstraction in programming means we need to create either an interface or abstract class which is non-concrete so that we can not create an instance of it.In our example, the EmployeeBusinessLogic and EmployeeDataAccess are concrete classes that mean we can create objects of it.

            // As per the Dependency Inversion Principle in C#, the EmployeeBusinessLogic (high-level module) should not depend on the concrete EmployeeDataAccess (low-level module) class. Both classes should depend on abstractions, meaning both classes should depend on either an interface or an abstract class.

        }
    }
}
