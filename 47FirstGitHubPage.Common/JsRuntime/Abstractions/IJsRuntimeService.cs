using System.Numerics;
using _47FirstGitHubPage.Common.JsRuntime.Structs;
using Microsoft.AspNetCore.Components;
using R3;

namespace _47FirstGitHubPage.Common.JsRuntime.Abstractions;

public interface IJsRuntimeService
{
    public ReadOnlyReactiveProperty<int> ScrollYValue { get; }

    public ReadOnlyReactiveProperty<Vector2> ScreenSize { get; }

    public ValueTask<BoundingRect> GetBoundingRect(ElementReference target);
}
