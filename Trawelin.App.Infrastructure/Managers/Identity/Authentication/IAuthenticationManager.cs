using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Authentication
{
    public interface IAuthenticationManager
    {

        Task<LoginResponseServiceResult> Login(GetTokenQuery getTokenQuery);

    }
}
