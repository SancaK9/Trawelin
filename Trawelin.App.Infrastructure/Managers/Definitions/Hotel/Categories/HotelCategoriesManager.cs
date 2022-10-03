using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Categories
{
    public class HotelCategoriesManager : IHotelCategoriesManager
    {

        private readonly HttpClient _httpClient;



        public HotelCategoriesManager(HttpClient httpClient)
        {
            _httpClient = httpClient;


        }

        public async Task<CategoryDtoServiceResult> CreateCategoryAsync(CreateCategoryCommand createCategoryCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCategoriesPostAsync(createCategoryCommand);
            return response;
        }

        public async Task<CategoryDtoServiceResult> DeleteCategoryAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCategoriesDeleteAsync(id);
            return response;
        }

        public async Task<CategoryDtoListServiceResult> GetCategoryAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCategoriesGetAsync();
            return response;
        }

        public async Task<CategoryDtoServiceResult> GetCategoryByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCategoriesGetAsync(id);
            return response;
        }

        public async Task<CategoryDtoServiceResult> UpdateCategoryAsync(UpdateCategoryCommand updateCategoryCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiCategoriesPutAsync(updateCategoryCommand);
            return response;
        }
    }
}
