using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class SuppliersProfile : Profile
    {
        public SuppliersProfile()
        {
            CreateMap<SupplierDto, CreateSupplierCommand>().ReverseMap();

            CreateMap<SupplierDto, UpdateSupplierCommand>().ReverseMap();
        }
    }
}
