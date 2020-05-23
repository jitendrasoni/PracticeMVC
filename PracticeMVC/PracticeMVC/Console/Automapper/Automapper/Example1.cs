using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Automapper.ApplicationLayer;
using Automapper.FoundationLayer;

namespace Automapper
{

    // Check StreetA value for the mapping for class and property name
    class Example1
    {
        public static void Automapper()
        {
            // WIthout Automapper 
            ProductRepository obj = new ProductRepository();
            ProductDetails objProductDetails = obj.getProduct();
            ProductNameDTO objDTO = new ProductNameDTO();
            objDTO.Name = objProductDetails.Name;

            // Define Mapping.
            Mapper.Initialize(config => { config.CreateMap<ProductDetails, ProductNameDTO>(); });

            // Get from the mapping.

            ProductNameDTO objDTO1 = Mapper.Map<ProductNameDTO>(objProductDetails);

            Console.Write(objDTO1.Name);
            Console.Read();
        }
    }
}
