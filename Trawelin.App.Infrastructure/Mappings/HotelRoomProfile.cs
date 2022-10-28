using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelRoomProfile : Profile
    {
        public HotelRoomProfile()
        {
            CreateMap<HotelRoomDto, CreateHotelRoomCommand>().ReverseMap();

            CreateMap<HotelRoomDto, UpdateHotelRoomCommand>().ReverseMap();
        }

    }
}
