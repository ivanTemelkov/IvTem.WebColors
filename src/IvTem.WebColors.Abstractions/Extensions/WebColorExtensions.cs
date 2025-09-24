using System.Diagnostics.CodeAnalysis;
using IvTem.WebColors.Abstractions.Model;
using IvTem.WebColors.Abstractions.Utility;

namespace IvTem.WebColors.Abstractions.Extensions;

public static class WebColorExtensions
{
    public static RgbaColor ToRgb([NotNull] this IWebColor color)
    {
        if (color is RgbaColor rgbaColor)
            return rgbaColor;

        if (color is HslaColor hslColor)
        {
            return hslColor.ToRgb();
        }

        if (color is HexColor hexColor)
        {
            return hexColor.ToRgb();
        }

        throw new NotImplementedException();
    }

    public static RgbaColor ToRgb([NotNull] this HslaColor color)
    {
        double chroma = (1.0 - Math.Abs(2.0 * color.Luminosity - 1.0)) * color.Saturation;
        double hueSection = color.Hue / 60.0;
        double secondComponent = chroma * (1.0 - Math.Abs(hueSection % 2.0 - 1.0));
        double matchLuminosity = color.Luminosity - chroma / 2.0;

        double redComponent;
        double greenComponent;
        double blueComponent;

        if (hueSection < 1)
            (redComponent, greenComponent, blueComponent) = (chroma, secondComponent, 0);
        else if (hueSection < 2)
            (redComponent, greenComponent, blueComponent) = (secondComponent, chroma, 0);
        else if (hueSection < 3)
            (redComponent, greenComponent, blueComponent) = (0, chroma, secondComponent);
        else if (hueSection < 4)
            (redComponent, greenComponent, blueComponent) = (0, secondComponent, chroma);
        else if (hueSection < 5)
            (redComponent, greenComponent, blueComponent) = (secondComponent, 0, chroma);
        else
            (redComponent, greenComponent, blueComponent) = (chroma, 0, secondComponent);

        byte redByte = ToByte((redComponent + matchLuminosity) * 255.0);
        byte greenByte = ToByte((greenComponent + matchLuminosity) * 255.0);
        byte blueByte = ToByte((blueComponent + matchLuminosity) * 255.0);

        return new RgbaColor(redByte, greenByte, blueByte, Math.Clamp(color.Alpha, 0.0, 1.0));

        static byte ToByte(double value)
        {
            double rounded = Math.Round(value, MidpointRounding.AwayFromZero);
            return (byte)Math.Clamp(rounded, 0.0, 255.0);
        }
    }

    public static RgbaColor ToRgb([NotNull] this HexColor color)
    {
        throw new NotImplementedException();
    }
    
    public static double ContrastRatio(this IWebColor color, IWebColor other)
    {
        var rgbColor = color.ToRgb();
        var rgbOther = other.ToRgb();
        var luminance1 = ColorUtil.GetRelativeLuminance(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        var luminance2 = ColorUtil.GetRelativeLuminance(rgbOther.Red, rgbOther.Green, rgbOther.Blue);

        var lighter = Math.Max(luminance1, luminance2);
        var darker = Math.Min(luminance1, luminance2);

        return (lighter + 0.05) / (darker + 0.05);
    }
}