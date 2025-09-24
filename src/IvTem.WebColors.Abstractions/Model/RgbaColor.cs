using IvTem.WebColors.Abstractions.Utility;

namespace IvTem.WebColors.Abstractions.Model;

public record RgbaColor : IWebColor
{
    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }
    public double Alpha { get; }
    
    public bool IsLight { get; }
    
    public RgbaColor(byte red, byte green, byte blue, double alpha = 1.0)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
        
        IsLight = ColorUtil.IsLightColor(red, green, blue);
    }

    

    public string Stringify()
    {
        return Alpha < 1.0
            ? $"rgba({Red}, {Green}, {Blue}, {Alpha})"
            : $"rgb({Red}, {Green}, {Blue})";
    }

    

    public void Deconstruct(out byte red, out byte green, out byte blue, out double alpha)
    {
        red = Red;
        green = Green;
        blue = Blue;
        alpha = Alpha;
    }
}