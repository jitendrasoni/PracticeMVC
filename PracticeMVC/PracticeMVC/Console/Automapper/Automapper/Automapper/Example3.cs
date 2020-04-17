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
    class Example3
    {
        private static IMapper _mapper;
        public static void AutoMapper()
        {
            // WIthout Automapper 
            ProductRepository obj = new ProductRepository();
            ProductDetails objProductDetails = obj.getProduct();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<SimpleProfile>();
            });

            config.AssertConfigurationIsValid();

            _mapper = new Mapper(config);


            // Get from the mapping.

            ProductNameDTO objDTO1 = _mapper.Map<ProductNameDTO>(objProductDetails);

            Console.Write($"Name is mapped with Custom Mapping Name {objDTO1.Name}");
            Console.Write($"Name is mapped with Description {objDTO1.AditionalDescription}");
            Console.Read();



        }
    }

    public class SimpleProfile : Profile
    {
        public SimpleProfile()
        {
            CreateMap<ProductDetails, ProductNameDTO>()
                .ForMember(dest => dest.AditionalDescription, member => member.MapFrom(source => source.Description))
                .ForMember(dest => dest.Name, member => member.MapFrom(source => "Jitendra Soni"));
        }
    }
}