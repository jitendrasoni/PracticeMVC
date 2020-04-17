using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using AutoMapper;
using Automapper.ApplicationLayer;
using Automapper.FoundationLayer;

namespace Automapper
{

        class Program
        {
            static void Main(string[] args)
            {
                // Sample Automapper all field mapping default
               //Example1.Automapper();
               // Sample Automapper all field mapping with class and property name
              // Example2.Automapper();
               // Mapping through the profile
               Example3.AutoMapper();

        }

        }
    }

  