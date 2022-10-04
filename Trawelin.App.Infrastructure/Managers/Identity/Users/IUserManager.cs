using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Users
{
    public interface IUserManager : IManager
    {
        Task<ApplicationUserDtoListServiceResult> GetUsersAsync();
        Task<ApplicationUserDtoServiceResult> CreateUserAsync(CreateUserCommand createUserCommand);
        Task<ApplicationUserDtoServiceResult> DeleteUserAsync(string id);
        Task<ApplicationUserDtoServiceResult> UpdateUserAsync(UpdateUserCommand updateUserCommand);
    }
}
