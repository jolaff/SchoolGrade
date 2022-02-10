using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SchoolGrade.PWA;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.ConfigureServices();

await builder.Build().RunAsync();