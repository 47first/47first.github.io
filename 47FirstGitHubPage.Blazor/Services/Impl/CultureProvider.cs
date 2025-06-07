using System.Globalization;
using _47FirstGitHubPage.Blazor.Consts;
using _47FirstGitHubPage.Blazor.Services.Abstractions;
using R3;

namespace _47FirstGitHubPage.Blazor.Services.Impl;

public class CultureProvider : ICultureProvider
{
    private readonly ReactiveProperty<CultureInfo> _currentCultureProperty = new(CultureInfo.CurrentCulture);

    public ReadOnlyReactiveProperty<CultureInfo> CurrentCulture => _currentCultureProperty;

    public void ChangeCurrentCulture(CultureInfo culture)
    {
        if (BlazorApplication.SupportedCultures.Contains(culture) == false)
        {
            throw new NotSupportedException($"Culture '{culture}' is not supported");
        }

        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;

        _currentCultureProperty.Value = culture;
    }
}
