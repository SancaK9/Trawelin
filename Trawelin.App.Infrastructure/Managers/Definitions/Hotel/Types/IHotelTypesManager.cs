using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Types
{
    public interface IHotelTypesManager : IManager
    {
        Task<HotelTypeDtoListServiceResult> GetHotelTypeAsync();
        Task<HotelTypeDtoServiceResult> GetHotelTypeByIdAsync(int id);
        Task<HotelTypeDtoServiceResult> CreateHotelTypeAsync(CreateHotelTypeCommand createHotelTypeCommand);
        Task<HotelTypeDtoServiceResult> DeleteHotelTypeAsync(int id);
        Task<HotelTypeDtoServiceResult> UpdateHotelTypeAsync(UpdateHotelTypeCommand updateHotelTypeCommand);
    }
}
