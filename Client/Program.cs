using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp.Client;
using Recurop;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddSyncfusionBlazor();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

builder.Services.AddRecurop();

await builder.Build().RunAsync();

