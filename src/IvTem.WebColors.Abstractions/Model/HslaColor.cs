namespace IvTem.WebColors.Abstractions.Model;

public sealed record HslaColor : IWebColor
{
    public double Hue { get; }
    public double Saturation { get; }
    public double Luminosity { get; }
    public double Alpha { get; }
    
    public HslaColor(double hue, double saturation, double luminosity, double alpha = 1)
    {
        Hue = NormalizeHue(hue);
        
        Saturation = Math.Clamp(saturation, 0.0, 1.0);
        Luminosity = Math.Clamp(luminosity, 0.0, 1.0);
        Alpha = Math.Clamp(alpha, 0.0, 1.0);
    }

    public void Deconstruct(out double hue, out double saturation, out double luminosity, out double alpha)
    {
        hue = Hue;
        saturation = Saturation;
        luminosity = Luminosity;
        alpha = Alpha;
    }

    public bool IsLight => throw new NotImplementedException();

    public string Stringify()
    {
        var saturation = (int)(Saturation * 100);
        var luminosity = (int)(Luminosity * 100);
        var alfa = (int)(Alpha * 100);
        
        return Alpha < 1.0
            ? $"hsl({Hue:F0}deg {saturation}% {luminosity}% / {Alpha}%)"
            : $"hsl({Hue:F0}deg {saturation}% {luminosity}%)";
    }

    private double NormalizeHue(double hue)
    {
        hue %= 360;
        
        if (hue < 0)
            hue += 360;
        
        return hue;
    }
}