using IvTem.WebColors.Abstractions.Model;

namespace IvTem.WebColors.Feature;

public sealed class ComputedColorSuccess : ComputedColorResult
{
    public IWebColor Color { get; }

    public ComputedColorSuccess(IWebColor color) : base (isSuccess: true)
    {
        Color = color;
    }
}