using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Hotels
{
    public class HotelManager : IHotelManager
    {

        private readonly HttpClient _httpClient;

        public HotelManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HotelDtoServiceResult> CreateHotelAsync(CreateHotelCommand createHotelCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelsPostAsync(createHotelCommand);
        }

        public async Task<HotelDtoServiceResult> DeleteHotelAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelsDeleteAsync(id);
        }

        public async Task<HotelDtoListServiceResult> GetHotelAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelsGetAsync();
        }

        public async Task<HotelDtoServiceResult> GetHotelByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelsGetAsync(id);
        }

        public async Task<HotelDtoServiceResult> UpdateHotelAsync(UpdateHotelCommand updateHotelCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelsPutAsync(updateHotelCommand);
        }
    }
}
