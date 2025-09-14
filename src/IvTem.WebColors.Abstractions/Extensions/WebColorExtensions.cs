using System.Diagnostics.CodeAnalysis;
using IvTem.WebColors.Abstractions.Model;

namespace IvTem.WebColors.Abstractions.Extensions;

public static class WebColorExtensions
{
    public static RgbaColor ToRgb([NotNull] this IWebColor color)
    {
        if (color is RgbaColor rgbaColor)
            return rgbaColor;

        if (color is HslColor hslColor)
        {
            return hslColor.ToRgb();
        }

        throw new NotImplementedException();
    }

    public static RgbaColor ToRgb([NotNull] this HslColor color)
    {
        throw new NotImplementedException();
    }
}