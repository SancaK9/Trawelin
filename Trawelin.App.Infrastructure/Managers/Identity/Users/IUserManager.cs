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
