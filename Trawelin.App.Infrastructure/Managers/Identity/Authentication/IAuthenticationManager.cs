using Trawelin.App.Infrastructure.ServiceApi;

namespace Trawelin.App.Infrastructure.Managers.Identity.Authentication
{
    public interface IAuthenticationManager : IManager
    {
        Task<LoginResponseServiceResult> Login(GetTokenQuery getTokenQuery);
    }
}
