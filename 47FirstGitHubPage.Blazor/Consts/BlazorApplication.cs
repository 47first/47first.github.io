using System.Globalization;

namespace _47FirstGitHubPage.Blazor.Consts;

public static class BlazorApplication
{
    public static readonly CultureInfo[] SupportedCultures =
    [
        CultureInfo.CreateSpecificCulture("en"),
        CultureInfo.CreateSpecificCulture("ru"),
    ];
}
