using Microsoft.JSInterop;

namespace IvTem.WebColors.Feature;

public sealed class ComputedColorService : IAsyncDisposable
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

    public async ValueTask<ComputedColorResult> GetComputedColor(string colorString)
    {
        try
        {
            var module = await ModuleTask.Value;
            var color = await module.InvokeAsync<string>("getComputedColor", colorString);

            return string.IsNullOrEmpty(color)
                ? new ComputedColorFailure($"Failed to convert '{colorString}' to a Web Color.")
                : new ComputedColorSuccess(color);
        }
        catch (Exception e)
        {
            return new ComputedColorFailure(e.Message);
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