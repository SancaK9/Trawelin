using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.RoomAccomodationTypes
{
    public class HotelRoomAccomodationTypeManager : IHotelRoomAccomodationTypeManager
    {
        private readonly HttpClient _httpClient;

        public HotelRoomAccomodationTypeManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> CreateRoomAccomodationTypeAsync(CreateRoomAccomodationTypeCommand createRoomAccomodationTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomAccomodationTypesPostAsync(createRoomAccomodationTypeCommand);
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> DeleteRoomAccomodationTypeAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomAccomodationTypesDeleteAsync(id);
        }

        public async Task<RoomAccomodationTypeDtoListServiceResult> GetRoomAccomodationTypeAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomAccomodationTypesGetAsync();
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> GetRoomAccomodationTypeByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomAccomodationTypesGetAsync(id);
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> UpdateRoomAccomodationTypeAsync(UpdateRoomAccomodationTypeCommand updateRoomAccomodationTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomAccomodationTypesPutAsync(updateRoomAccomodationTypeCommand);
        }
    }
}
