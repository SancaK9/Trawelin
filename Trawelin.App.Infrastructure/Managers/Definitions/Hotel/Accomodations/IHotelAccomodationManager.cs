using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Accomodations
{
    public interface IHotelAccomodationManager
    {

        Task<AccomodationDtoListServiceResult> GetAccomodationAsync();
        Task<AccomodationDtoServiceResult> GetAccomodationByIdAsync(int id);
        Task<AccomodationDtoServiceResult> CreateAccomodationAsync(CreateAccomodationCommand createAccomodationCommand);
        Task<AccomodationDtoServiceResult> DeleteAccomodationAsync(int id);
        Task<AccomodationDtoServiceResult> UpdateAccomodationAsync(UpdateAccomodationCommand updateAccomodationCommand);
    }
}
