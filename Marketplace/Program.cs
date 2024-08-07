using Blazored.LocalStorage;
using Marketplace;
using Marketplace.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHotKeys2();
builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddTransient<INotificationsService, NotificationsService>();
builder.Services.AddTransient<IArticlesService, ArticlesService>();

await builder.Build().RunAsync();
