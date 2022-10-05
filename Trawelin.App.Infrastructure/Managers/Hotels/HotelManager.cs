using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var response = await service.ApiHotelsPostAsync(createHotelCommand);
            return response;
        }

        public async Task<HotelDtoServiceResult> DeleteHotelAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelsDeleteAsync(id);
            return response;
        }

        public async Task<HotelDtoListServiceResult> GetHotelAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelsGetAsync();
            return response;
        }

        public async Task<HotelDtoServiceResult> GetHotelByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelsGetAsync(id);
            return response;
        }

        public async Task<HotelDtoServiceResult> UpdateHotelAsync(UpdateHotelCommand updateHotelCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiHotelsPutAsync(updateHotelCommand);
            return response;
        }
    }
}
