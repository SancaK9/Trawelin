using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Categories
{
    public interface IHotelCategoriesManager : IManager
    {
        Task<CategoryDtoListServiceResult> GetCategoryAsync();
        Task<CategoryDtoServiceResult> GetCategoryByIdAsync(int id);
        Task<CategoryDtoServiceResult> CreateCategoryAsync(CreateCategoryCommand createCategoryCommand);
        Task<CategoryDtoServiceResult> DeleteCategoryAsync(int id);
        Task<CategoryDtoServiceResult> UpdateCategoryAsync(UpdateCategoryCommand updateCategoryCommand);
    }
}
