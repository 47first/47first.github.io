using _47FirstGitHubPage.Common.JsRuntime.Abstractions;
using _47FirstGitHubPage.Common.JsRuntime.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace _47FirstGitHubPage.Common.JsRuntime.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJsRuntimeService(this IServiceCollection services)
    {
        services.AddSingleton<IJsRuntimeService, JsRuntimeService>();

        return services;
    }
}
