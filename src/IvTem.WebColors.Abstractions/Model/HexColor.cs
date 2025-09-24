using IvTem.WebColors.Abstractions.Utility;

namespace IvTem.WebColors.Abstractions.Model;

public record HexColor : IWebColor
{
    public string Hex { get; }

    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }
    public double Alpha { get; }
    
    public bool IsLight { get; }

    public HexColor(string hex)
    {
        Hex = hex;
        
        if (ColorUtil.TryParse(hex, out var red, out var green, out var blue, out var alpha) == false)
            throw new ArgumentException("Invalid hex color", nameof(hex));
        
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
        IsLight = ColorUtil.IsLightColor(red, green, blue);
    }
    
    public void Deconstruct(out string hex)
    {
        hex = Hex;
    }

    public string Stringify() 
        => Hex;
    
}