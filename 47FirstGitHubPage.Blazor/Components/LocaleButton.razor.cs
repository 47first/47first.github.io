using _47FirstGitHubPage.Blazor.Consts;
using _47FirstGitHubPage.Blazor.Pages;
using _47FirstGitHubPage.Blazor.Resources;
using _47FirstGitHubPage.Blazor.Services.Abstractions;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using R3;

namespace _47FirstGitHubPage.Blazor.Components;

public partial class LocaleButton : ComponentBase, IDisposable
{
    private int _cultureIndexCounter;
    private IDisposable? _observers;

    [Inject]
    public required ICultureProvider CultureProvider { get; set; }

    [Inject]
    public required IStringLocalizer<ComponentsLocalization> Localizer { get; set; }

    [Parameter]
    public EventCallback CultureChanged { get; set; }

    protected override void OnInitialized()
    {
        _observers = CultureProvider.CurrentCulture
            .Subscribe(_ => CultureChanged.InvokeAsync());
    }

    public void Dispose()
    {
        _observers?.Dispose();
    }

    private void ChangeLanguage_OnClick()
    {
        _cultureIndexCounter = (_cultureIndexCounter + 1) % BlazorApplication.SupportedCultures.Length;

        CultureProvider.ChangeCurrentCulture(BlazorApplication.SupportedCultures[_cultureIndexCounter]);
    }
}
