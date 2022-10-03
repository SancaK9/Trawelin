using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
