using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Accomodations
{
    public class HotelAccomodationManager : IHotelAccomodationManager
    {

        private readonly HttpClient _httpClient;


        public HotelAccomodationManager(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<AccomodationDtoServiceResult> CreateAccomodationAsync(CreateAccomodationCommand createAccomodationCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiAccomodationsPostAsync(createAccomodationCommand);
            return response;
        }

        public async Task<AccomodationDtoServiceResult> DeleteAccomodationAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiAccomodationsDeleteAsync(id);
            return response;
        }

        public async Task<AccomodationDtoListServiceResult> GetAccomodationAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiAccomodationsGetAsync();
            return response;
        }

        public async Task<AccomodationDtoServiceResult> GetAccomodationByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiAccomodationsGetAsync(id);
            return response;
        }

        public async Task<AccomodationDtoServiceResult> UpdateAccomodationAsync(UpdateAccomodationCommand updateAccomodationCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiAccomodationsPutAsync(updateAccomodationCommand);
            return response;
        }
    }
}
