using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelRoomTypeProfile : Profile
    {
        public HotelRoomTypeProfile()
        {
            CreateMap<RoomTypeDto, CreateRoomTypeCommand>().ReverseMap();

            CreateMap<RoomTypeDto, UpdateRoomTypeCommand>().ReverseMap();
        }
    }
}
