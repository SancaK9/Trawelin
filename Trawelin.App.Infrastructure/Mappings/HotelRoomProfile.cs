using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
