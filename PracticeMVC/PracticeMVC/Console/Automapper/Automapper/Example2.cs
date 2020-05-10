using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Automapper
{

    // Check StreetA value for the mapping for class and property name
    class Example2
    {
        public static void Automapper()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Data.Models.Customer, Web.ViewModels.Customer>();
            });

            Data.Models.Customer dataCustomer = new Data.Models.Customer
            {
                FirstName = "Jitendra",
                LastName = "Soni",
                Address = new Data.Models.Address
                {
                    StreetA = "Parammatta",
                    City = "Sydney",
                    State = "VA"
                },
                Company = new Data.Models.Company
                {
                    Name = "ABC",
                    PhoneNumber = "(061) 000-0000"
                }
            };

            Web.ViewModels.Customer vmCustomer = Mapper.Map<Web.ViewModels.Customer>(dataCustomer);
        }

    }
       
}
namespace Data.Models
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public Company Company { get; set; }
    }
    public class Address
    {
        public string StreetA { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
    }
}

namespace Web.ViewModels
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AddressStreet { get; set; }

        public string AddressCity { get; set; }

        public string AddressState { get; set; }

        public string CompanyName { get; set; }

        public string CompanyPhoneNumber { get; set; }
    }
}
