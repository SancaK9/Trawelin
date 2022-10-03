using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Trawelin.App;
using Trawelin.App.Infrastructure.Managers.Identity.Authentication;
using Trawelin.App.Infrastructure.Managers.Identity.Definitions.Region;
using Trawelin.App.Infrastructure.Managers.Identity.Users;
using Trawelin.App.Infrastructure.Managers.Definitions.Suppliers;
using Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Categories;
using Trawelin.App.Infrastructure.Managers.Definitions.Hotel.Types;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();


builder.Services.AddScoped<IAuthenticationManager, AuthenticationManager>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IRegionManager, RegionManager>();
builder.Services.AddScoped<ISuppliersManager, SuppliersManager>();
builder.Services.AddScoped<IHotelCategoriesManager, HotelCategoriesManager>();
builder.Services.AddScoped<IHotelTypesManager, HotelTypesManager>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

await builder.Build().RunAsync();
