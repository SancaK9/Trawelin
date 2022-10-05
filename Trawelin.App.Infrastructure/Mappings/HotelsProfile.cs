using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
