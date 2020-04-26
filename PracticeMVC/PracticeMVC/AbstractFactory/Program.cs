using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
             //CreatePizza.Migretta;

        }

        internal Piza GetPizza(IPiza piza)
        {

            return null;
        }

    }


    internal class Piza
    {
        public int OrderNumber { get; set; }   
        public string Name { get; set; }
        public string Description { get; set; }
    }
    internal class Ingrediants
    {
        public int Bread { get; set; }
    }

    interface IPiza
    {
        Piza getPiza();
    }

    class Chicago : IPiza
    {
        public Piza getPiza()
        {
            throw new NotImplementedException();
        }
    }

    class Margherita : IPiza
    {
        public Piza getPiza()
        {
            throw new NotImplementedException();
        }
    }
    //Create Pizza
    //Chicago , Margherita
}
