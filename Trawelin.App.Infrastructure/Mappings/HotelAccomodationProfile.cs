using AutoMapper;
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
