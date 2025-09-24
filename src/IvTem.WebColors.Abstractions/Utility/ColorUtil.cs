using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.RegularExpressions;
using IvTem.WebColors.Abstractions.Extensions;
using IvTem.WebColors.Abstractions.Model;

namespace IvTem.WebColors.Abstractions.Utility;

public static partial class ColorUtil
{
    [GeneratedRegex(@"^rgba?\s*\(\s*(?<red>\d{1,3})\s*,\s*(?<green>\d{1,3})\s*,\s*(?<blue>\d{1,3})(?:\s*,\s*(?<alpha>[0-9]*\.?[0-9]+))?\s*\)$",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant)]
    private static partial Regex ComputedColorRegex();

    
    [GeneratedRegex(
        @"^#(?:(?<r>[0-9A-F]{2})(?<g>[0-9A-F]{2})(?<b>[0-9A-F]{2})(?<a>[0-9A-F]{2})?|(?<r>[0-9A-F])(?<g>[0-9A-F])(?<b>[0-9A-F])(?<a>[0-9A-F])?)$",
        RegexOptions.CultureInvariant | RegexOptions.IgnoreCase)]
    private static partial Regex HexRegex();
    
    public static bool TryParseWebColor(
        string? computedColor,
        out RgbaColor webColor)
    {
        webColor = new RgbaColor(0, 0, 0);
        
        if (string.IsNullOrWhiteSpace(computedColor))
            return false;

        var match = ComputedColorRegex().Match(computedColor.Trim());
        if (match.Success == false)
            return false;

        var red = ClampToByte(int.Parse(match.Groups["red"].Value, CultureInfo.InvariantCulture));
        var green = ClampToByte(int.Parse(match.Groups["green"].Value, CultureInfo.InvariantCulture));
        var blue = ClampToByte(int.Parse(match.Groups["blue"].Value, CultureInfo.InvariantCulture));

        if (match.Groups["alpha"].Success)
        {
            var alpha = ClampToUnit(double.Parse(match.Groups["alpha"].Value, CultureInfo.InvariantCulture));
            
            webColor = new RgbaColor(red, green, blue, (byte)(alpha * 100));
            return true;
        }
            
        webColor = new RgbaColor(red, green, blue);
        return true;
    }

    // Uses the WCAG definition of relative luminance
    // https://www.w3.org/WAI/GL/wiki/Relative_luminance
    public static bool IsLightColor([NotNull] this IWebColor webColor)
    {
        var (red, green, blue, _) = webColor.ToRgb();
        return IsLightColor(red, green, blue);
    }
    
    // Uses the WCAG definition of relative luminance
    // https://www.w3.org/WAI/GL/wiki/Relative_luminance
    public static bool IsLightColor(byte red, byte green, byte blue)
    {
        var relativeLuminance = GetRelativeLuminance(red, green, blue);
        return relativeLuminance > 0.179;
    }
    
    /// <summary>
    /// Try to parse a CSS hex color string into RGBA byte values.
    /// Accepts #RGB, #RGBA, #RRGGBB, #RRGGBBAA.
    /// If alpha is omitted, it defaults to 255 (opaque).
    /// </summary>
    public static bool TryParse(
        string input,
        out byte red,
        out byte green,
        out byte blue,
        out byte alpha)
    {
        red = green = blue = 0;
        alpha = 255;

        var match = HexRegex().Match(input);
        
        if (match.Success == false)
            return false;

        red = HexToByte(match.Groups["red"].Value);
        green = HexToByte(match.Groups["green"].Value);
        blue = HexToByte(match.Groups["blue"].Value);

        var alphaGroup = match.Groups["alpha"];
        
        if (alphaGroup is { Success: true, Length: > 0 })
            alpha = HexToByte(alphaGroup.Value);

        return true;
    }

    private static byte HexToByte(string hexValue)
    {
        // If shorthand (1 digit), duplicate it (e.g., "f" -> "ff")
        if (hexValue.Length == 1)
            hexValue = new string(hexValue[0], 2);
        
        return Convert.ToByte(hexValue, 16);
    }

    public static double GetRelativeLuminance(byte red, byte green, byte blue)
    {
        // Normalize RGB components to 0..1
        var redNormalized = red / 255.0;
        var greenNormalized = green / 255.0;
        var blueNormalized = blue / 255.0;

        // Apply gamma correction (linearize)
        var redLinear = (redNormalized <= 0.03928)
            ? redNormalized / 12.92
            : Math.Pow((redNormalized + 0.055) / 1.055, 2.4);

        var greenLinear = (greenNormalized <= 0.03928)
            ? greenNormalized / 12.92
            : Math.Pow((greenNormalized + 0.055) / 1.055, 2.4);

        var blueLinear = (blueNormalized <= 0.03928)
            ? blueNormalized / 12.92
            : Math.Pow((blueNormalized + 0.055) / 1.055, 2.4);

        return 
            0.2126 * redLinear +
            0.7152 * greenLinear +
            0.0722 * blueLinear;
    }
    
    private static byte ClampToByte(int value)
        => (byte)Math.Max(0, Math.Min(255, value));
    
    private static double ClampToUnit(double value)
        => Math.Max(0.0, Math.Min(1.0, value));
}