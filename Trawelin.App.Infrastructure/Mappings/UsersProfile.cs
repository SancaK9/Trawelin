using AutoMapper;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Mappings
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<ApplicationUserDto, CreateUserCommand>().ReverseMap();

            CreateMap<ApplicationUserDto, UpdateUserCommand>().ReverseMap();
        }
    }
}
