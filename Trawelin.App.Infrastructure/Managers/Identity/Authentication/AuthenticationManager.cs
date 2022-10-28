using Blazored.LocalStorage;
using System.Net.Http.Headers;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Authentication
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public AuthenticationManager(
            HttpClient httpClient,
            ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public async Task<LoginResponseServiceResult> Login(GetTokenQuery getTokenQuery)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);

            //Get Token From Service
            var response = await service.ApiLoginAsync(getTokenQuery);

            if (response.Succeeded)
            {
                var token = response.Data.Token;
                
                await _localStorage.SetItemAsync(StorageConstants.Local.AuthToken, token);

                await _localStorage.SetItemAsync(StorageConstants.Local.userId, response.Data.User.Id);
                await _localStorage.SetItemAsync(StorageConstants.Local.userUsername, response.Data.User.UserName);
                await _localStorage.SetItemAsync(StorageConstants.Local.userEmail, response.Data.User.Email);

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            }
            return response;
        }

      
    }
}
