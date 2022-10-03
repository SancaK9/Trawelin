using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.RoomTypes
{
    public interface IHotelRoomTypesManager
    {
        Task<RoomTypeDtoListServiceResult> GetRoomTypeAsync();
        Task<RoomTypeDtoServiceResult> GetRoomTypeByIdAsync(int id);
        Task<RoomTypeDtoServiceResult> CreateRoomTypeAsync(CreateRoomTypeCommand createRoomTypeCommand);
        Task<RoomTypeDtoServiceResult> DeleteRoomTypeAsync(int id);
        Task<RoomTypeDtoServiceResult> UpdateRoomTypeAsync(UpdateRoomTypeCommand updateRoomTypeCommand);
    }
}
