using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Definitions.Region
{
    public class RegionManager : IRegionManager
    {

        private readonly HttpClient _httpClient;
    


        public RegionManager(HttpClient httpClient)
        {
            this._httpClient = httpClient;

        }
        #region Country

        public async Task<CountryDtoServiceResult> CreateCountryAsync(CreateCountryCommand createCountryCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCountriesPostAsync(createCountryCommand);
            return response;
        }

        public async Task<CountryDtoServiceResult> DeleteCountryAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCountriesDeleteAsync(id);
            return response;
        }

        public async Task<CountryDtoListServiceResult> GetCountryAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCountriesGetAsync();
            return response;
        }

        public async Task<CountryDtoServiceResult> GetCountryByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCountriesGetAsync(id);
            return response;
        }

        public async Task<CountryDtoServiceResult> UpdateCountryAsync(UpdateCountryCommand updateCountryCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCountriesPutAsync(updateCountryCommand);
            return response;
        }

        #endregion

        #region City
        public async Task<CityDtoServiceResult> CreateCityAsync(CreateCityCommand createCityCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCitiesPostAsync(createCityCommand);
            return response;
        }
        public async Task<CityDtoServiceResult> DeleteCityAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCitiesDeleteAsync(id);
            return response;
        }

        public async Task<CityDtoListServiceResult> GetCitiesAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCitiesGetAsync();
            return response;
        }
        public async Task<CityDtoListServiceResult> GetCitiesByCountryIdAsync(int countryId)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCitiesByCountryAsync(countryId);
            return response;
        }

        public async Task<CityDtoServiceResult> GetCityByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCitiesGetAsync(id);
            return response;
        }
        public async Task<CityDtoServiceResult> UpdateCityAsync(UpdateCityCommand updateCityCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCitiesPutAsync(updateCityCommand);
            return response;
        }

        #endregion

        #region District
        public async Task<DistrictDtoServiceResult> CreateDistrictAsync(CreateDistrictCommand createDistrictCommand)
        {
            
                Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
                var response = await service.ApiDistrictsPostAsync(createDistrictCommand);
                return response;
            
        }


        public async Task<DistrictDtoServiceResult> DeleteDistrictAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiDistrictsDeleteAsync(id);
            return response;
        }

        public async Task<DistrictDtoListServiceResult> GetDistrictAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiDistrictsGetAsync();
            return response;
        }

        public async Task<DistrictDtoListServiceResult> GetDistrictByCityIdAsync(int cityId)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiDistrictsByCityAsync(cityId);
            return response;
        }

        public async Task<DistrictDtoServiceResult> GetDistrictByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiDistrictsGetAsync(id);
            return response;
        }
        public async Task<DistrictDtoServiceResult> UpdateDistrictAsync(UpdateDistrictCommand updateDistrictCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiDistrictsPutAsync(updateDistrictCommand);
            return response;
        }
        #endregion

        #region Village
        public async Task<VillageDtoServiceResult> CreateVillageAsync(CreateVillageCommand createVillageCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiVillagesPostAsync(createVillageCommand);
            return response;
        }
        public async Task<VillageDtoServiceResult> DeleteVillageAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiVillagesDeleteAsync(id);
            return response;
        }
        public async Task<VillageDtoListServiceResult> GetVillageAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiVillagesGetAsync();
            return response;
        }
        public async Task<VillageDtoListServiceResult> GetVillageByDistrictIdAsync(int districtId)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiVillagesByDistrictAsync(districtId);
            return response;
        }

        public async Task<VillageDtoServiceResult> GetVillageByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiVillagesGetAsync(id);
            return response;
        }
        public async Task<VillageDtoServiceResult> UpdateVillageAsync(UpdateVillageCommand updateVillageCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiVillagesPutAsync(updateVillageCommand);
            return response;
        }
        #endregion
    }
}
