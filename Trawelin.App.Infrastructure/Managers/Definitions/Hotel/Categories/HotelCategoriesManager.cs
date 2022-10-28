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
            return await service.ApiCategoriesPostAsync(createCategoryCommand); 
        }

        public async Task<CategoryDtoServiceResult> DeleteCategoryAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCategoriesDeleteAsync(id);
        }

        public async Task<CategoryDtoListServiceResult> GetCategoryAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCategoriesGetAsync();
        }

        public async Task<CategoryDtoServiceResult> GetCategoryByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCategoriesGetAsync(id);
        }

        public async Task<CategoryDtoServiceResult> UpdateCategoryAsync(UpdateCategoryCommand updateCategoryCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiCategoriesPutAsync(updateCategoryCommand);
        }
    }
}
