using Microsoft.AspNetCore.Components;

namespace _47FirstGitHubPage.Blazor.Components;

public partial class FullscreenFixedBackground
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public required string CssClass { get; set; }

    [Parameter]
    public required int ZIndex { get; set; }
}
