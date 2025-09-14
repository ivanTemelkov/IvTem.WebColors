namespace IvTem.WebColors.Abstractions.Model;

public record HslColor(double Hue, double Saturation, double Luminosity) : IWebColor
{
    public string Stringify() 
        => $"hsl({Hue}, {Saturation}, {Luminosity})";
}