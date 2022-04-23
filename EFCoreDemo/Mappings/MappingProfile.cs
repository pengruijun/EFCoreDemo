using AutoMapper;
using EFCoreDemo.Dtos;
using EFCoreDemo.Models;

namespace EFCoreDemo.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Blog, BlogDto>()
            .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Posts, opt => opt.MapFrom(src => src.Posts));
        CreateMap<Post, PostDto>()
            .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));


    }
}