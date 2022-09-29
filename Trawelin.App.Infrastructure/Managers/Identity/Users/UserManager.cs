using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;
using Blazored.LocalStorage;
using Trawelin.App.Infrastructure.Constants.Storage;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace Trawelin.App.Infrastructure.Managers.Identity.Users
{
    public class UserManager : IUserManager
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;


        public  UserManager(HttpClient httpClient, ILocalStorageService localStorage)
        {
            this. _httpClient = httpClient;
            this._localStorage = localStorage;
            
        }


        public async Task<ApplicationUserDtoServiceResult> CreateUserAsync(CreateUserCommand createUserCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiUsersPostAsync(createUserCommand);
            return response;
        }

        public async Task<ApplicationUserDtoServiceResult> DeleteUserAsync(string id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiUsersDeleteAsync(id);
            return response;
        }

        public async Task<ApplicationUserDtoListServiceResult> GetUsersAsync()
        {

            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiUsersGetAsync();
            return response;
        }

        public async Task<ApplicationUserDtoServiceResult> UpdateUserAsync(UpdateUserCommand updateUserCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiUsersPutAsync(updateUserCommand);
            return response;
        }
    }
}
