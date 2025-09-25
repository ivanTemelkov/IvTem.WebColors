using IvTem.WebColors.Abstractions.Feature.ColorService;
using IvTem.WebColors.Abstractions.Utility;
using Microsoft.JSInterop;

namespace IvTem.WebColors.Feature.ColorService;

public sealed class ComputedColorService : IWebColorService, IAsyncDisposable
{
    private Lazy<Task<IJSObjectReference>> ModuleTask { get; }

    public ComputedColorService(IJSRuntime jsRuntime)
    {
        // TODO Should I use try-catch here?
        ModuleTask = new Lazy<Task<IJSObjectReference>>(()
            => jsRuntime
                .InvokeAsync<IJSObjectReference>("import", "./_content/IvTem.WebColors/js/computedStyleService.js")
                .AsTask());
    }

    public async ValueTask<WebColorResult> GetColor(string colorString)
    {
        try
        {
            var module = await ModuleTask.Value;
            var color = await module.InvokeAsync<string>("getComputedColor", colorString);

            if (string.IsNullOrEmpty(color))
                return new WebColorFailure($"Failed to convert '{colorString}' to a Web Color.");

            if (ColorUtil.TryParseWebColor(color, out var webColor) == false)
                return new WebColorFailure($"Failed to convert '{colorString}' to a Web Color.");

            return new WebColorSuccess(webColor);
        }
        catch (Exception e)
        {
            return new WebColorFailure(e.Message);
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (ModuleTask.IsValueCreated)
        {
            var module = await ModuleTask.Value;
            await module.DisposeAsync();
        }
    }
}