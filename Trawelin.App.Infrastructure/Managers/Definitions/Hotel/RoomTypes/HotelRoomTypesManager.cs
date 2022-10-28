using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.RoomTypes
{
    public class HotelRoomTypesManager : IHotelRoomTypesManager
    {
        private readonly HttpClient _httpClient;

        public HotelRoomTypesManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RoomTypeDtoServiceResult> CreateRoomTypeAsync(CreateRoomTypeCommand createRoomTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomTypesPostAsync(createRoomTypeCommand);
        }

        public async Task<RoomTypeDtoServiceResult> DeleteRoomTypeAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomTypesDeleteAsync(id);
        }

        public async Task<RoomTypeDtoListServiceResult> GetRoomTypeAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomTypesGetAsync();
        }

        public async Task<RoomTypeDtoServiceResult> GetRoomTypeByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomTypesGetAsync(id);
        }

        public async Task<RoomTypeDtoServiceResult> UpdateRoomTypeAsync(UpdateRoomTypeCommand updateRoomTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiRoomTypesPutAsync(updateRoomTypeCommand);
        }
    }
}
