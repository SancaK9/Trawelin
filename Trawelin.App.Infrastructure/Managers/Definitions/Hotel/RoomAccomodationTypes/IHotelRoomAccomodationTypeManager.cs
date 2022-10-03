using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.RoomAccomodationTypes
{
    public interface IHotelRoomAccomodationTypeManager
    {

        Task<RoomAccomodationTypeDtoListServiceResult> GetRoomAccomodationTypeAsync();
        Task<RoomAccomodationTypeDtoServiceResult> GetRoomAccomodationTypeByIdAsync(int id);
        Task<RoomAccomodationTypeDtoServiceResult> CreateRoomAccomodationTypeAsync(CreateRoomAccomodationTypeCommand createRoomAccomodationTypeCommand);
        Task<RoomAccomodationTypeDtoServiceResult> DeleteRoomAccomodationTypeAsync(int id);
        Task<RoomAccomodationTypeDtoServiceResult> UpdateRoomAccomodationTypeAsync(UpdateRoomAccomodationTypeCommand updateRoomAccomodationTypeCommand);
    }
}
