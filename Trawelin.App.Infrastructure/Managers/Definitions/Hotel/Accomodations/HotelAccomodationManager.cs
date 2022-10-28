using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Accomodations
{
    public class HotelAccomodationManager : IHotelAccomodationManager
    {

        private readonly HttpClient _httpClient;

        public HotelAccomodationManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AccomodationDtoServiceResult> CreateAccomodationAsync(CreateAccomodationCommand createAccomodationCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiAccomodationsPostAsync(createAccomodationCommand);
        }

        public async Task<AccomodationDtoServiceResult> DeleteAccomodationAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiAccomodationsDeleteAsync(id);
        }

        public async Task<AccomodationDtoListServiceResult> GetAccomodationAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiAccomodationsGetAsync();
        }

        public async Task<AccomodationDtoServiceResult> GetAccomodationByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiAccomodationsGetAsync(id);
        }

        public async Task<AccomodationDtoServiceResult> UpdateAccomodationAsync(UpdateAccomodationCommand updateAccomodationCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiAccomodationsPutAsync(updateAccomodationCommand);
        }
    }
}
