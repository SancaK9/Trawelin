using Blazored.LocalStorage;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Users
{
    public class UserManager : IUserManager
    {
        private readonly HttpClient _httpClient;

        public  UserManager(HttpClient httpClient)
        {
            this. _httpClient = httpClient;
        }

        public async Task<ApplicationUserDtoServiceResult> CreateUserAsync(CreateUserCommand createUserCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiUsersPostAsync(createUserCommand);
        }

        public async Task<ApplicationUserDtoServiceResult> DeleteUserAsync(string id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiUsersDeleteAsync(id);
        }

        public async Task<ApplicationUserDtoListServiceResult> GetUsersAsync()
        {

            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiUsersGetAsync();
        }

        public async Task<ApplicationUserDtoServiceResult> UpdateUserAsync(UpdateUserCommand updateUserCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiUsersPutAsync(updateUserCommand);
        }
    }
}
