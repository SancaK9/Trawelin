using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var response = await service.ApiRoomAccomodationTypesPostAsync(createRoomAccomodationTypeCommand);
            return response;
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> DeleteRoomAccomodationTypeAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomAccomodationTypesDeleteAsync(id);
            return response;
        }

        public async Task<RoomAccomodationTypeDtoListServiceResult> GetRoomAccomodationTypeAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomAccomodationTypesGetAsync();
            return response;
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> GetRoomAccomodationTypeByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomAccomodationTypesGetAsync(id);
            return response;
        }

        public async Task<RoomAccomodationTypeDtoServiceResult> UpdateRoomAccomodationTypeAsync(UpdateRoomAccomodationTypeCommand updateRoomAccomodationTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiRoomAccomodationTypesPutAsync(updateRoomAccomodationTypeCommand);
            return response;
        }
    }
}
