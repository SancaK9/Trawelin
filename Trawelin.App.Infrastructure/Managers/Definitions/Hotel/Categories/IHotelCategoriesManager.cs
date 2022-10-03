using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Categories
{
    public interface IHotelCategoriesManager
    {

        Task<CategoryDtoListServiceResult> GetCategoryAsync();
        Task<CategoryDtoServiceResult> GetCategoryByIdAsync(int id);
        Task<CategoryDtoServiceResult> CreateCategoryAsync(CreateCategoryCommand createCategoryCommand);
        Task<CategoryDtoServiceResult> DeleteCategoryAsync(int id);
        Task<CategoryDtoServiceResult> UpdateCategoryAsync(UpdateCategoryCommand updateCategoryCommand);

    }
}
