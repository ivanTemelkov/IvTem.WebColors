namespace IvTem.WebColors.Feature;

public sealed class ComputedColorSuccess : ComputedColorResult
{
    public string Color { get; }

    public ComputedColorSuccess(string color) : base (isSuccess: true)
    {
        Color = color;
    }
}