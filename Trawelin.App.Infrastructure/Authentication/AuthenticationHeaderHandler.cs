using Blazored.LocalStorage;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Constants.Storage;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Authentication
{
    public class AuthenticationHeaderHandler : DelegatingHandler
    {
        private readonly ILocalStorageService _localStorage;

        public AuthenticationHeaderHandler(ILocalStorageService localStorage)
            => this._localStorage = localStorage;

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request.Headers.Authorization?.Scheme != "Bearer")
            {
                request.Headers.Add(StorageConstants.Local.headerName, "Bearer " + await _localStorage.GetItemAsync<string>(StorageConstants.Local.AuthToken));
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}