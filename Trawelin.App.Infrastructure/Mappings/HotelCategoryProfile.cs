using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class HotelCategoryProfile : Profile
    {
        public HotelCategoryProfile()
        {
            CreateMap<CategoryDto, CreateCategoryCommand>().ReverseMap();

            CreateMap<CategoryDto, UpdateCategoryCommand>().ReverseMap();
        }
    }
}
