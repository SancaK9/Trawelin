using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Definitions.Region
{
    public interface IRegionManager
    {
        //Country
        Task<CountryDtoListServiceResult> GetCountryAsync();
        Task<CountryDtoServiceResult> GetCountryById(int id);
        Task<CountryDtoServiceResult> CreateCountryAsync(CreateCountryCommand createCountryCommand);
        Task<CountryDtoServiceResult> DeleteCountryAsync(int id);
        Task<CountryDtoServiceResult> UpdateCountryAsync(UpdateCountryCommand updateCountryCommand);

        //City
        Task<CityDtoListServiceResult> GetCitiesAsync();
        Task<CityDtoListServiceResult> GetCitiesByCountryIdAsync(int countryId);
        Task<CityDtoServiceResult> GetCityById(int id);
        Task<CityDtoServiceResult> CreateCityAsync(CreateCityCommand createCityCommand);
        Task<CityDtoServiceResult> DeleteCityAsync(int id);
        Task<CityDtoServiceResult> UpdateCityAsync(UpdateCityCommand updateCityCommand);

        //District
        Task<DistrictDtoListServiceResult> GetDistrictAsync();
        Task<DistrictDtoListServiceResult> GetDistrictByCityIdAsync(int cityId);
        Task<DistrictDtoServiceResult> GetDistrictById(int id);
        Task<DistrictDtoServiceResult> CreateDistrictAsync(CreateDistrictCommand createDistrictCommand);
        Task<DistrictDtoServiceResult> DeleteDistrictAsync(int id);
        Task<DistrictDtoServiceResult> UpdateDistrictAsync(UpdateDistrictCommand updateDistrictCommand);

        //Village
        Task<VillageDtoListServiceResult> GetVillageAsync();
        Task<VillageDtoListServiceResult> GetVillageByDistrictIdAsync(int districtId);
        Task<VillageDtoServiceResult> GetVillageById(int id);
        Task<VillageDtoServiceResult> CreateVillageAsync(CreateVillageCommand createVillageCommand);
        Task<VillageDtoServiceResult> DeleteVillageAsync(int id);
        Task<VillageDtoServiceResult> UpdateVillageAsync(UpdateVillageCommand updateVillageCommand);

    }
}
