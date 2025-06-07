using Microsoft.AspNetCore.Components;

namespace _47FirstGitHubPage.Blazor.Components;

public partial class BackgroundSectionImage
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public required string AdditionalClasses { get; set; }

    [Parameter]
    public required string StyleOverride { get; set; }
}
