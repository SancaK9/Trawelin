using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelAccomodationProfile : Profile
    {
        public HotelAccomodationProfile()
        {
            CreateMap<AccomodationDto, CreateAccomodationCommand>().ReverseMap();

            CreateMap<AccomodationDto, UpdateAccomodationCommand>().ReverseMap();
        }
    }
}
