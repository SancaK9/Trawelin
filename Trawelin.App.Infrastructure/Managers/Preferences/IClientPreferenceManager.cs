using BlazorHero.CleanArchitecture.Shared.Wrapper;
using System.Threading.Tasks;
using Trawelin.App.Infrastructure.Settings;

namespace Trawelin.App.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IManager
    {
        Task<IPreference> GetPreference();
        Task<bool> ToggleDarkModeAsync();
        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}