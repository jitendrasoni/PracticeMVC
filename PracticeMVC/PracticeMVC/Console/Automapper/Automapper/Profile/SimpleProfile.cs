using AutoMapper;
using Automapper.ApplicationLayer;
using Automapper.FoundationLayer;

namespace Automapper
{
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