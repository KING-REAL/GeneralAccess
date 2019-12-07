using AutoMapper;
using GeneralAccess.Entities;
using GeneralAccess.Framework.Resources;

namespace GeneralAccess.WebApi.Extensions
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthIcon, IconResources>()
                .ForMember(dest => dest.iconcode, opt => opt.MapFrom(src => src.IconCode))
                .ForMember(dest => dest.description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.createdtime, opt => opt.MapFrom(src => src.CreatedOn));

            CreateMap<IconResources, AuthIcon>();
        }
    }
}
