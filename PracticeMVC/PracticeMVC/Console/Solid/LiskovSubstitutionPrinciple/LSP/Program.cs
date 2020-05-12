using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        //The Liskov Substitution Principle(LSP) states that 
        //you should be able to use any derived class instead of a parent class and have it behave" +
        //in the same manner without modification".It ensures that a derived class does not affect the
        //behavior of the parent class, in other words,
        //that a derived class must be substitutable for its base class.
        static void Main(string[] args)
        {
            ///behavioral subtyping 
            ///A type S is a behavioral subtype of a type T if each behavior allowed by the specification of S is also allowed by the specification of T. This requires, in particular, that for each method M of T,
            ///the specification of M in S is stronger than the one in T.
           //Liskov Substitution Principle – is one of the SOLID principles defined by Barbara Liskov.Principle is based on the parent-child relationship in other words inheritance features of OOD(Object Oriented Design). Principle says “When class S is a subtype of class T then an object of type T can be replaced by an object of type S without affecting functionality/correctness of the implementation or program”.
           //In simple words it says “Places in implementation(Class/Function) that use a base class, in other words consume a service of a base class, must work correctly when the base class object is replaced by a child class (derived class) object.”
        }
    }
}
