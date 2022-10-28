using BlazorHero.CleanArchitecture.Shared.Wrapper;
using MudBlazor;
using Trawelin.App.Infrastructure.Settings;

namespace Trawelin.App.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IManager
    {
        Task<MudTheme> GetCurrentThemeAsync();
        Task<bool> IsRTL();
        Task<bool> ToggleLayoutDirection();
        Task<IPreference> GetPreference();
        Task<bool> ToggleDarkModeAsync();
        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}