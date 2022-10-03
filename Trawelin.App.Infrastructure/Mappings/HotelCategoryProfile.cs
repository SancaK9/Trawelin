using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
