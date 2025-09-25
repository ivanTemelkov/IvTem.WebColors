using IvTem.WebColors.Abstractions.Model;

namespace IvTem.WebColors.Abstractions.Feature.ColorService;

public sealed class WebColorSuccess : WebColorResult
{
    public IWebColor Color { get; }

    public WebColorSuccess(IWebColor color) : base (isSuccess: true)
    {
        Color = color;
    }
}