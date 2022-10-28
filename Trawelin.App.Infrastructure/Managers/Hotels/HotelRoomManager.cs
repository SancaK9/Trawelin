using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Hotels
{
    public class HotelRoomManager : IHotelRoomManager
    {
        private readonly HttpClient _httpClient;

        public HotelRoomManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
     
        public async Task<HotelRoomDtoServiceResult> CreateHotelRoomAsync(CreateHotelRoomCommand createHotelRoomCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelRoomsPostAsync(createHotelRoomCommand);
        }

        public async Task<HotelRoomDtoServiceResult> DeleteHotelRoomAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelRoomsDeleteAsync(id);
        }

        public async Task<HotelRoomDtoServiceResult> GetHotelRoomByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelRoomsGetAsync(id);
        }

        public async Task<HotelRoomDtoServiceResult> UpdateHotelRoomAsync(UpdateHotelRoomCommand updateHotelRoomCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelRoomsPutAsync(updateHotelRoomCommand);
        }
    }
}
