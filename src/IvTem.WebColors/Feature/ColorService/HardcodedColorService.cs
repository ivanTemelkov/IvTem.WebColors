using IvTem.WebColors.Abstractions.Feature.ColorService;
using IvTem.WebColors.Abstractions.Utility;

namespace IvTem.WebColors.Feature.ColorService;

public sealed class HardcodedColorService : IWebColorService
{
    public ValueTask<WebColorResult> GetColor(string colorString)
    {
        WebColorResult webColorResult = (ColorList.All.TryGetValue(colorString, out var result))
            ? new WebColorSuccess(result)
            : new WebColorFailure($"Failed to convert '{colorString}' to a Web Color.");

        return ValueTask.FromResult(webColorResult);
    }
}