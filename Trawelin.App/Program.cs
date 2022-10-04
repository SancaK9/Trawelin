using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Trawelin.App;
using System.Globalization;
using Trawelin.App.Infrastructure.Constants.Localization;
using Trawelin.App.Infrastructure.Managers;
using Trawelin.App.Infrastructure.Managers.Preferences;
using Trawelin.App.Infrastructure.Settings;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});




//Managers Init
var managers = typeof(IManager);

var types = managers
    .Assembly
    .GetExportedTypes()
    .Where(t => t.IsClass && !t.IsAbstract)
    .Select(t => new
    {
        Service = t.GetInterface($"I{t.Name}"),
        Implementation = t
    })
    .Where(t => t.Service != null);

foreach (var type in types)
{
    if (managers.IsAssignableFrom(type.Service))
    {
        builder.Services.AddTransient(type.Service, type.Implementation);
    }
}
// End Managers Init




builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var host = builder.Build();

var storageService = host.Services.GetRequiredService<IClientPreferenceManager>();
if (storageService != null)
{
    CultureInfo culture;
    var preference = await storageService.GetPreference() as ClientPreference;
    if (preference != null)
        culture = new CultureInfo(preference.LanguageCode);
    else
        culture = new CultureInfo(LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US");
    CultureInfo.DefaultThreadCurrentCulture = culture;
    CultureInfo.DefaultThreadCurrentUICulture = culture;
}

await builder.Build().RunAsync();
