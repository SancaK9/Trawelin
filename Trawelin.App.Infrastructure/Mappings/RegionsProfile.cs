using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class RegionsProfile : Profile
    {

        public RegionsProfile() {

            //Country
            CreateMap<CountryDto, UpdateCountryCommand>().ReverseMap();
            CreateMap<CountryDto, CreateCountryCommand>().ReverseMap();

            //City
            CreateMap<CityDto, UpdateCityCommand>().ReverseMap();
            CreateMap<CityDto, CreateCityCommand>().ReverseMap();

            //District
            CreateMap<DistrictDto, UpdateDistrictCommand>().ReverseMap();
            CreateMap<DistrictDto, CreateDistrictCommand>().ReverseMap();

            //Village
            CreateMap<VillageDto, UpdateVillageCommand>().ReverseMap();
            CreateMap<VillageDto, CreateVillageCommand>().ReverseMap();
        
        }

    }
}
