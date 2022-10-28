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
            return await service.ApiHotelTypesPostAsync(createHotelTypeCommand);
        }

        public async Task<HotelTypeDtoServiceResult> DeleteHotelTypeAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelTypesDeleteAsync(id);
        }

        public async Task<HotelTypeDtoListServiceResult> GetHotelTypeAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelTypesGetAsync();
        }

        public async Task<HotelTypeDtoServiceResult> GetHotelTypeByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelTypesGetAsync(id);
        }

        public async Task<HotelTypeDtoServiceResult> UpdateHotelTypeAsync(UpdateHotelTypeCommand updateHotelTypeCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiHotelTypesPutAsync(updateHotelTypeCommand);
        }
    }
}
