using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelRoomAccomodationProfile : Profile
    {
        public HotelRoomAccomodationProfile()
        {
            CreateMap<RoomAccomodationTypeDto, CreateRoomAccomodationTypeCommand>().ReverseMap();

            CreateMap<RoomAccomodationTypeDto, UpdateRoomAccomodationTypeCommand>().ReverseMap();
        }
    }
}
