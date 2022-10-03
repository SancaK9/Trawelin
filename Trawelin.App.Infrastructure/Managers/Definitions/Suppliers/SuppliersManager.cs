using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Suppliers
{
    public class SuppliersManager : ISuppliersManager
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;


        public SuppliersManager(HttpClient httpClient, ILocalStorageService localStorage)
        {
            this._httpClient = httpClient;
            this._localStorage = localStorage;

        }

        public async Task<SupplierDtoServiceResult> CreateSupplierAsync(CreateSupplierCommand createSupplierCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiSuppliersPostAsync(createSupplierCommand);
            return response;
        }

        public async Task<SupplierDtoServiceResult> DeleteSupplierAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiSuppliersDeleteAsync(id);
            return response;
        }

        public async Task<SupplierDtoServiceResult> GetSupplierByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiSuppliersGetAsync(id);
            return response;
        }

        public async Task<SupplierDtoListServiceResult> GetSuppliersAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiSuppliersGetAsync();
            return response;
        }

        public async Task<SupplierDtoServiceResult> UpdateSupplierAsync(UpdateSupplierCommand updateSupplierCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            var response = await service.ApiSuppliersPutAsync(updateSupplierCommand);
            return response;
        }
    }
}
