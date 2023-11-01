using BlazorApp2.Client.Services;
using BlazorApp2.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IDealsService, ClientDealsService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
