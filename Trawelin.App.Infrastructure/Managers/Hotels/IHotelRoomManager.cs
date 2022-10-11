using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Hotels
{
    public interface IHotelRoomManager : IManager
    {
        Task<HotelRoomDtoServiceResult> GetHotelRoomByIdAsync(int id);
        Task<HotelRoomDtoServiceResult> CreateHotelRoomAsync(CreateHotelRoomCommand createHotelRoomCommand);
        Task<HotelRoomDtoServiceResult> DeleteHotelRoomAsync(int id);
        Task<HotelRoomDtoServiceResult> UpdateHotelRoomAsync(UpdateHotelRoomCommand updateHotelRoomCommand);

    }
}
