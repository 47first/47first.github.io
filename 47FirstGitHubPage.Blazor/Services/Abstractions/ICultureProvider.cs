using System.Globalization;
using R3;

namespace _47FirstGitHubPage.Blazor.Services.Abstractions;

public interface ICultureProvider
{
    public ReadOnlyReactiveProperty<CultureInfo> CurrentCulture { get; }

    public void ChangeCurrentCulture(CultureInfo culture);
}
