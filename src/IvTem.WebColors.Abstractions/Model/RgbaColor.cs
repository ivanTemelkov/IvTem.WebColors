namespace IvTem.WebColors.Abstractions.Model;

public record RgbaColor(byte Red, byte Green, byte Blue, byte Alpha = 100) : IWebColor
{
    public string Stringify()
    {
        return Alpha < 100
            ? $"rgba({Red}, {Green}, {Blue}, {Alpha/100.0})"
            : $"rgb({Red}, {Green}, {Blue})";
    }
}