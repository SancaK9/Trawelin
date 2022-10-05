using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Hotels
{
    public interface IHotelManager : IManager
    {
        Task<HotelDtoListServiceResult> GetHotelAsync();
        Task<HotelDtoServiceResult> GetHotelByIdAsync(int id);
        Task<HotelDtoServiceResult> CreateHotelAsync(CreateHotelCommand createHotelCommand);
        Task<HotelDtoServiceResult> DeleteHotelAsync(int id);
        Task<HotelDtoServiceResult> UpdateHotelAsync(UpdateHotelCommand updateHotelCommand);
    }
}
