using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace _47FirstGitHubPage.Blazor.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    public required IStringLocalizer<HomePageLocalization> PageLocalizer { get; set; }
}
