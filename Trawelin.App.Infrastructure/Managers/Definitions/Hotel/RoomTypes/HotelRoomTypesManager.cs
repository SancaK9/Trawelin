using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var response = await service.ApiRoomTypesPostAsync(createRoomTypeCommand);
            return response;
        }

        public async Task<RoomTypeDtoServiceResult> DeleteRoomTypeAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomTypesDeleteAsync(id);
            return response;
        }

        public async Task<RoomTypeDtoListServiceResult> GetRoomTypeAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomTypesGetAsync();
            return response;
        }

        public async Task<RoomTypeDtoServiceResult> GetRoomTypeByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomTypesGetAsync(id);
            return response;
        }

        public async Task<RoomTypeDtoServiceResult> UpdateRoomTypeAsync(UpdateRoomTypeCommand updateRoomTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomTypesPutAsync(updateRoomTypeCommand);
            return response;
        }
    }
}
