using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Suppliers
{
    public interface ISuppliersManager : IManager
    {
        Task<SupplierDtoListServiceResult> GetSuppliersAsync();
        Task<SupplierDtoServiceResult> GetSupplierByIdAsync(int id);
        Task<SupplierDtoServiceResult> CreateSupplierAsync(CreateSupplierCommand createSupplierCommand);
        Task<SupplierDtoServiceResult> DeleteSupplierAsync(int id);
        Task<SupplierDtoServiceResult> UpdateSupplierAsync(UpdateSupplierCommand updateSupplierCommand);
    }
}
