using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using EventEaseAppBlazor;
using EventEaseAppBlazor.Services; // Asegúrate de tener este using

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped<EventService>(); // <--- Agrega esta línea
builder.Services.AddSingleton<UserSessionService>();

await builder.Build().RunAsync();