using _47FirstGitHubPage.Blazor;
using _47FirstGitHubPage.Blazor.Consts;
using _47FirstGitHubPage.Blazor.Services.Abstractions;
using _47FirstGitHubPage.Blazor.Services.Impl;
using _47FirstGitHubPage.Common.Helpers;
using _47FirstGitHubPage.Common.JsRuntime.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddLocalization();
builder.Services.AddJsRuntimeService();

builder.Services.AddSingleton<ICultureProvider, CultureProvider>();

await WebAssemblyCultureResourcesHelper.LoadResourcesForCultures(BlazorApplication.SupportedCultures);

await builder.Build().RunAsync();
