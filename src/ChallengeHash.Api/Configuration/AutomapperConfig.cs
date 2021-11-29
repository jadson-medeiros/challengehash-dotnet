using AutoMapper;
using ChallengeHash.Api.ViewModels;
using ChallengeHash.Business.Models;

namespace ChallengeHash.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ProductViewModel, Product>().ReverseMap();

            CreateMap<Product, ProductViewModel>()
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount));
        }
    }
}