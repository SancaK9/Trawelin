using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelTypeProfile : Profile
    {
        public HotelTypeProfile()
        {
            CreateMap<HotelTypeDto, CreateHotelTypeCommand>().ReverseMap();

            CreateMap<HotelTypeDto, UpdateHotelTypeCommand>().ReverseMap();
        }
    }
}
