using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.RoomTypes
{
    public interface IHotelRoomTypesManager : IManager
    {
        Task<RoomTypeDtoListServiceResult> GetRoomTypeAsync();
        Task<RoomTypeDtoServiceResult> GetRoomTypeByIdAsync(int id);
        Task<RoomTypeDtoServiceResult> CreateRoomTypeAsync(CreateRoomTypeCommand createRoomTypeCommand);
        Task<RoomTypeDtoServiceResult> DeleteRoomTypeAsync(int id);
        Task<RoomTypeDtoServiceResult> UpdateRoomTypeAsync(UpdateRoomTypeCommand updateRoomTypeCommand);
    }
}
