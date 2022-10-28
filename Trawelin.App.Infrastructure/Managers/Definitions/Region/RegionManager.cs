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
            return await service.ApiCountriesPostAsync(createCountryCommand);
        }

        public async Task<CountryDtoServiceResult> DeleteCountryAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCountriesDeleteAsync(id);
        }

        public async Task<CountryDtoListServiceResult> GetCountryAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCountriesGetAsync();
        }

        public async Task<CountryDtoServiceResult> GetCountryByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCountriesGetAsync(id);
        }

        public async Task<CountryDtoServiceResult> UpdateCountryAsync(UpdateCountryCommand updateCountryCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCountriesPutAsync(updateCountryCommand);
        }

        #endregion

        #region City

        public async Task<CityDtoServiceResult> CreateCityAsync(CreateCityCommand createCityCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCitiesPostAsync(createCityCommand);
        }
        public async Task<CityDtoServiceResult> DeleteCityAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCitiesDeleteAsync(id);
        }

        public async Task<CityDtoListServiceResult> GetCitiesAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCitiesGetAsync();
        }
        public async Task<CityDtoListServiceResult> GetCitiesByCountryIdAsync(int countryId)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCitiesByCountryAsync(countryId);
        }

        public async Task<CityDtoServiceResult> GetCityByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCitiesGetAsync(id);
        }

        public async Task<CityDtoServiceResult> UpdateCityAsync(UpdateCityCommand updateCityCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCitiesPutAsync(updateCityCommand);
        }

        #endregion

        #region District

        public async Task<DistrictDtoServiceResult> CreateDistrictAsync(CreateDistrictCommand createDistrictCommand)
        {
            
                Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
                return await service.ApiDistrictsPostAsync(createDistrictCommand);
        }

        public async Task<DistrictDtoServiceResult> DeleteDistrictAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiDistrictsDeleteAsync(id);
        }

        public async Task<DistrictDtoListServiceResult> GetDistrictAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiDistrictsGetAsync();
        }

        public async Task<DistrictDtoListServiceResult> GetDistrictByCityIdAsync(int cityId)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiDistrictsByCityAsync(cityId);
        }

        public async Task<DistrictDtoServiceResult> GetDistrictByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiDistrictsGetAsync(id);
        }

        public async Task<DistrictDtoServiceResult> UpdateDistrictAsync(UpdateDistrictCommand updateDistrictCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiDistrictsPutAsync(updateDistrictCommand);
        }

        #endregion

        #region Village

        public async Task<VillageDtoServiceResult> CreateVillageAsync(CreateVillageCommand createVillageCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiVillagesPostAsync(createVillageCommand);
        }

        public async Task<VillageDtoServiceResult> DeleteVillageAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiVillagesDeleteAsync(id);
        }

        public async Task<VillageDtoListServiceResult> GetVillageAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiVillagesGetAsync();
        }

        public async Task<VillageDtoListServiceResult> GetVillageByDistrictIdAsync(int districtId)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiVillagesByDistrictAsync(districtId);
        }

        public async Task<VillageDtoServiceResult> GetVillageByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiVillagesGetAsync(id);
        }

        public async Task<VillageDtoServiceResult> UpdateVillageAsync(UpdateVillageCommand updateVillageCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiVillagesPutAsync(updateVillageCommand);
        }

        #endregion

    }
}
