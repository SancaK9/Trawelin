using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var response = await service.ApiHotelRoomsPostAsync(createHotelRoomCommand);
            return response;
        }

        public async Task<HotelRoomDtoServiceResult> DeleteHotelRoomAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelRoomsDeleteAsync(id);
            return response;
        }

        public async Task<HotelRoomDtoServiceResult> GetHotelRoomByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelRoomsGetAsync(id);
            return response;
        }

        public async Task<HotelRoomDtoServiceResult> UpdateHotelRoomAsync(UpdateHotelRoomCommand updateHotelRoomCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelRoomsPutAsync(updateHotelRoomCommand);
            return response;
        }
    }
}
