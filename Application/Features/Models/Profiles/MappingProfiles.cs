using Application.Features.Models.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, GetListModelListItemDto>()./*ForMember().*/ReverseMap();

        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();

        //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
        //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
        //.ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand.Name))
        //.ForMember(dest => dest.Fuel, opt => opt.MapFrom(src => src.Fuel.Name))
        //.ForMember(dest => dest.Transmission, opt => opt.MapFrom(src => src.Transmission.Name))
        //.ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
        //.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
        //.ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
        //.ForMember(dest => dest.Kilometers, opt => opt.MapFrom(src => src.Kilometers))
        //.ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
        //.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
        //.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

    }
}
