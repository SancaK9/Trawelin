using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
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
          
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                return response;
            }
            else
            {
                return response;
            }
        }

      



    }
}
