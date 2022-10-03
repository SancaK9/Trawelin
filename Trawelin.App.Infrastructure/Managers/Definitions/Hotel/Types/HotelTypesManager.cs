using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Types
{
    public class HotelTypesManager : IHotelTypesManager
    {

        private readonly HttpClient _httpClient;


        public HotelTypesManager(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }


        public async Task<HotelTypeDtoServiceResult> CreateHotelTypeAsync(CreateHotelTypeCommand createHotelTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelTypesPostAsync(createHotelTypeCommand);
            return response;
        }

        public async Task<HotelTypeDtoServiceResult> DeleteHotelTypeAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelTypesDeleteAsync(id);
            return response;
        }

        public async Task<HotelTypeDtoListServiceResult> GetHotelTypeAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelTypesGetAsync();
            return response;
        }

        public async Task<HotelTypeDtoServiceResult> GetHotelTypeByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelTypesGetAsync(id);
            return response;
        }

        public async Task<HotelTypeDtoServiceResult> UpdateHotelTypeAsync(UpdateHotelTypeCommand updateHotelTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelTypesPutAsync(updateHotelTypeCommand);
            return response;
        }
    }
}
