using Trawelin.App.Infrastructure.Constants.Storage;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Suppliers
{
    public class SuppliersManager : ISuppliersManager
    {
        private readonly HttpClient _httpClient;

        public SuppliersManager(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<SupplierDtoServiceResult> CreateSupplierAsync(CreateSupplierCommand createSupplierCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiSuppliersPostAsync(createSupplierCommand);
        }

        public async Task<SupplierDtoServiceResult> DeleteSupplierAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiSuppliersDeleteAsync(id);
        }

        public async Task<SupplierDtoServiceResult> GetSupplierByIdAsync(int id)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiSuppliersGetAsync(id);
        }

        public async Task<SupplierDtoListServiceResult> GetSuppliersAsync()
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiSuppliersGetAsync();
        }

        public async Task<SupplierDtoServiceResult> UpdateSupplierAsync(UpdateSupplierCommand updateSupplierCommand)
        {
            Client service = new Client(StorageConstants.Local.baseUrl, _httpClient);
            return await service.ApiSuppliersPutAsync(updateSupplierCommand);
        }
    }
}
