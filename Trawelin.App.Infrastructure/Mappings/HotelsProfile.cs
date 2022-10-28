using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelsProfile : Profile
    {
        public HotelsProfile()
        {
            CreateMap<HotelDto, CreateHotelCommand>().ReverseMap();

            CreateMap<HotelDto, UpdateHotelCommand>().ReverseMap();

            CreateMap<HotelGeneralCommandDto, HotelGeneralDto>().ReverseMap();
        }
    }
}
