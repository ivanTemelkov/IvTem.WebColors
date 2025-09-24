using IvTem.WebColors.Abstractions.Model;

namespace IvTem.WebColors.Abstractions.Utility;

public static class ColorList
{
    // === Individual colors as static readonly properties ===
    public static readonly RgbaColor AliceBlue = new(240, 248, 255);
    public static readonly RgbaColor AntiqueWhite = new(250, 235, 215);
    public static readonly RgbaColor Aqua = new(0, 255, 255);
    public static readonly RgbaColor Aquamarine = new(127, 255, 212);
    public static readonly RgbaColor Azure = new(240, 255, 255);
    public static readonly RgbaColor Beige = new(245, 245, 220);
    public static readonly RgbaColor Bisque = new(255, 228, 196);
    public static readonly RgbaColor Black = new(0, 0, 0);
    public static readonly RgbaColor BlanchedAlmond = new(255, 235, 205);
    public static readonly RgbaColor Blue = new(0, 0, 255);
    public static readonly RgbaColor BlueViolet = new(138, 43, 226);
    public static readonly RgbaColor Brown = new(165, 42, 42);
    public static readonly RgbaColor BurlyWood = new(222, 184, 135);
    public static readonly RgbaColor CadetBlue = new(95, 158, 160);
    public static readonly RgbaColor Chartreuse = new(127, 255, 0);
    public static readonly RgbaColor Chocolate = new(210, 105, 30);
    public static readonly RgbaColor Coral = new(255, 127, 80);
    public static readonly RgbaColor CornflowerBlue = new(100, 149, 237);
    public static readonly RgbaColor Cornsilk = new(255, 248, 220);
    public static readonly RgbaColor Crimson = new(220, 20, 60);
    public static readonly RgbaColor Cyan = new(0, 255, 255);
    public static readonly RgbaColor DarkBlue = new(0, 0, 139);
    public static readonly RgbaColor DarkCyan = new(0, 139, 139);
    public static readonly RgbaColor DarkGoldenrod = new(184, 134, 11);
    public static readonly RgbaColor DarkGray = new(169, 169, 169);
    public static readonly RgbaColor DarkGreen = new(0, 100, 0);
    public static readonly RgbaColor DarkGrey = new(169, 169, 169);
    public static readonly RgbaColor DarkKhaki = new(189, 183, 107);
    public static readonly RgbaColor DarkMagenta = new(139, 0, 139);
    public static readonly RgbaColor DarkOliveGreen = new(85, 107, 47);
    public static readonly RgbaColor DarkOrange = new(255, 140, 0);
    public static readonly RgbaColor DarkOrchid = new(153, 50, 204);
    public static readonly RgbaColor DarkRed = new(139, 0, 0);
    public static readonly RgbaColor DarkSalmon = new(233, 150, 122);
    public static readonly RgbaColor DarkSeaGreen = new(143, 188, 143);
    public static readonly RgbaColor DarkSlateBlue = new(72, 61, 139);
    public static readonly RgbaColor DarkSlateGray = new(47, 79, 79);
    public static readonly RgbaColor DarkSlateGrey = new(47, 79, 79);
    public static readonly RgbaColor DarkTurquoise = new(0, 206, 209);
    public static readonly RgbaColor DarkViolet = new(148, 0, 211);
    public static readonly RgbaColor DeepPink = new(255, 20, 147);
    public static readonly RgbaColor DeepSkyBlue = new(0, 191, 255);
    public static readonly RgbaColor DimGray = new(105, 105, 105);
    public static readonly RgbaColor DimGrey = new(105, 105, 105);
    public static readonly RgbaColor DodgerBlue = new(30, 144, 255);
    public static readonly RgbaColor FireBrick = new(178, 34, 34);
    public static readonly RgbaColor FloralWhite = new(255, 250, 240);
    public static readonly RgbaColor ForestGreen = new(34, 139, 34);
    public static readonly RgbaColor Fuchsia = new(255, 0, 255);
    public static readonly RgbaColor Gainsboro = new(220, 220, 220);
    public static readonly RgbaColor GhostWhite = new(248, 248, 255);
    public static readonly RgbaColor Gold = new(255, 215, 0);
    public static readonly RgbaColor Goldenrod = new(218, 165, 32);
    public static readonly RgbaColor Gray = new(128, 128, 128);
    public static readonly RgbaColor Green = new(0, 128, 0);
    public static readonly RgbaColor GreenYellow = new(173, 255, 47);
    public static readonly RgbaColor Grey = new(128, 128, 128);
    public static readonly RgbaColor HoneyDew = new(240, 255, 240);
    public static readonly RgbaColor HotPink = new(255, 105, 180);
    public static readonly RgbaColor IndianRed = new(205, 92, 92);
    public static readonly RgbaColor Indigo = new(75, 0, 130);
    public static readonly RgbaColor Ivory = new(255, 255, 240);
    public static readonly RgbaColor Khaki = new(240, 230, 140);
    public static readonly RgbaColor Lavender = new(230, 230, 250);
    public static readonly RgbaColor LavenderBlush = new(255, 240, 245);
    public static readonly RgbaColor LawnGreen = new(124, 252, 0);
    public static readonly RgbaColor LemonChiffon = new(255, 250, 205);
    public static readonly RgbaColor LightBlue = new(173, 216, 230);
    public static readonly RgbaColor LightCoral = new(240, 128, 128);
    public static readonly RgbaColor LightCyan = new(224, 255, 255);
    public static readonly RgbaColor LightGoldenrodYellow = new(250, 250, 210);
    public static readonly RgbaColor LightGray = new(211, 211, 211);
    public static readonly RgbaColor LightGreen = new(144, 238, 144);
    public static readonly RgbaColor LightGrey = new(211, 211, 211);
    public static readonly RgbaColor LightPink = new(255, 182, 193);
    public static readonly RgbaColor LightSalmon = new(255, 160, 122);
    public static readonly RgbaColor LightSeaGreen = new(32, 178, 170);
    public static readonly RgbaColor LightSkyBlue = new(135, 206, 250);
    public static readonly RgbaColor LightSlateGray = new(119, 136, 153);
    public static readonly RgbaColor LightSlateGrey = new(119, 136, 153);
    public static readonly RgbaColor LightSteelBlue = new(176, 196, 222);
    public static readonly RgbaColor LightYellow = new(255, 255, 224);
    public static readonly RgbaColor Lime = new(0, 255, 0);
    public static readonly RgbaColor LimeGreen = new(50, 205, 50);
    public static readonly RgbaColor Linen = new(250, 240, 230);
    public static readonly RgbaColor Magenta = new(255, 0, 255);
    public static readonly RgbaColor Maroon = new(128, 0, 0);
    public static readonly RgbaColor MediumAquamarine = new(102, 205, 170);
    public static readonly RgbaColor MediumBlue = new(0, 0, 205);
    public static readonly RgbaColor MediumOrchid = new(186, 85, 211);
    public static readonly RgbaColor MediumPurple = new(147, 112, 219);
    public static readonly RgbaColor MediumSeaGreen = new(60, 179, 113);
    public static readonly RgbaColor MediumSlateBlue = new(123, 104, 238);
    public static readonly RgbaColor MediumSpringGreen = new(0, 250, 154);
    public static readonly RgbaColor MediumTurquoise = new(72, 209, 204);
    public static readonly RgbaColor MediumVioletRed = new(199, 21, 133);
    public static readonly RgbaColor MidnightBlue = new(25, 25, 112);
    public static readonly RgbaColor MintCream = new(245, 255, 250);
    public static readonly RgbaColor MistyRose = new(255, 228, 225);
    public static readonly RgbaColor Moccasin = new(255, 228, 181);
    public static readonly RgbaColor NavajoWhite = new(255, 222, 173);
    public static readonly RgbaColor Navy = new(0, 0, 128);
    public static readonly RgbaColor OldLace = new(253, 245, 230);
    public static readonly RgbaColor Olive = new(128, 128, 0);
    public static readonly RgbaColor OliveDrab = new(107, 142, 35);
    public static readonly RgbaColor Orange = new(255, 165, 0);
    public static readonly RgbaColor OrangeRed = new(255, 69, 0);
    public static readonly RgbaColor Orchid = new(218, 112, 214);
    public static readonly RgbaColor PaleGoldenrod = new(238, 232, 170);
    public static readonly RgbaColor PaleGreen = new(152, 251, 152);
    public static readonly RgbaColor PaleTurquoise = new(175, 238, 238);
    public static readonly RgbaColor PaleVioletRed = new(219, 112, 147);
    public static readonly RgbaColor PapayaWhip = new(255, 239, 213);
    public static readonly RgbaColor PeachPuff = new(255, 218, 185);
    public static readonly RgbaColor Peru = new(205, 133, 63);
    public static readonly RgbaColor Pink = new(255, 192, 203);
    public static readonly RgbaColor Plum = new(221, 160, 221);
    public static readonly RgbaColor PowderBlue = new(176, 224, 230);
    public static readonly RgbaColor Purple = new(128, 0, 128);
    public static readonly RgbaColor RebeccaPurple = new(102, 51, 153);
    public static readonly RgbaColor Red = new(255, 0, 0);
    public static readonly RgbaColor RosyBrown = new(188, 143, 143);
    public static readonly RgbaColor RoyalBlue = new(65, 105, 225);
    public static readonly RgbaColor SaddleBrown = new(139, 69, 19);
    public static readonly RgbaColor Salmon = new(250, 128, 114);
    public static readonly RgbaColor SandyBrown = new(244, 164, 96);
    public static readonly RgbaColor SeaGreen = new(46, 139, 87);
    public static readonly RgbaColor SeaShell = new(255, 245, 238);
    public static readonly RgbaColor Sienna = new(160, 82, 45);
    public static readonly RgbaColor Silver = new(192, 192, 192);
    public static readonly RgbaColor SkyBlue = new(135, 206, 235);
    public static readonly RgbaColor SlateBlue = new(106, 90, 205);
    public static readonly RgbaColor SlateGray = new(112, 128, 144);
    public static readonly RgbaColor SlateGrey = new(112, 128, 144);
    public static readonly RgbaColor Snow = new(255, 250, 250);
    public static readonly RgbaColor SpringGreen = new(0, 255, 127);
    public static readonly RgbaColor SteelBlue = new(70, 130, 180);
    public static readonly RgbaColor Tan = new(210, 180, 140);
    public static readonly RgbaColor Teal = new(0, 128, 128);
    public static readonly RgbaColor Thistle = new(216, 191, 216);
    public static readonly RgbaColor Tomato = new(255, 99, 71);
    public static readonly RgbaColor Turquoise = new(64, 224, 208);
    public static readonly RgbaColor Violet = new(238, 130, 238);
    public static readonly RgbaColor Wheat = new(245, 222, 179);
    public static readonly RgbaColor White = new(255, 255, 255);
    public static readonly RgbaColor WhiteSmoke = new(245, 245, 245);
    public static readonly RgbaColor Yellow = new(255, 255, 0);
    public static readonly RgbaColor YellowGreen = new(154, 205, 50);

    // === Dictionary containing all names (case-insensitive) ===
    public static readonly Dictionary<string, RgbaColor> All =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { nameof(AliceBlue), AliceBlue },
            { nameof(AntiqueWhite), AntiqueWhite },
            { nameof(Aqua), Aqua },
            { nameof(Aquamarine), Aquamarine },
            { nameof(Azure), Azure },
            { nameof(Beige), Beige },
            { nameof(Bisque), Bisque },
            { nameof(Black), Black },
            { nameof(BlanchedAlmond), BlanchedAlmond },
            { nameof(Blue), Blue },
            { nameof(BlueViolet), BlueViolet },
            { nameof(Brown), Brown },
            { nameof(BurlyWood), BurlyWood },
            { nameof(CadetBlue), CadetBlue },
            { nameof(Chartreuse), Chartreuse },
            { nameof(Chocolate), Chocolate },
            { nameof(Coral), Coral },
            { nameof(CornflowerBlue), CornflowerBlue },
            { nameof(Cornsilk), Cornsilk },
            { nameof(Crimson), Crimson },
            { nameof(Cyan), Cyan },
            { nameof(DarkBlue), DarkBlue },
            { nameof(DarkCyan), DarkCyan },
            { nameof(DarkGoldenrod), DarkGoldenrod },
            { nameof(DarkGray), DarkGray },
            { nameof(DarkGreen), DarkGreen },
            { nameof(DarkGrey), DarkGrey },
            { nameof(DarkKhaki), DarkKhaki },
            { nameof(DarkMagenta), DarkMagenta },
            { nameof(DarkOliveGreen), DarkOliveGreen },
            { nameof(DarkOrange), DarkOrange },
            { nameof(DarkOrchid), DarkOrchid },
            { nameof(DarkRed), DarkRed },
            { nameof(DarkSalmon), DarkSalmon },
            { nameof(DarkSeaGreen), DarkSeaGreen },
            { nameof(DarkSlateBlue), DarkSlateBlue },
            { nameof(DarkSlateGray), DarkSlateGray },
            { nameof(DarkSlateGrey), DarkSlateGrey },
            { nameof(DarkTurquoise), DarkTurquoise },
            { nameof(DarkViolet), DarkViolet },
            { nameof(DeepPink), DeepPink },
            { nameof(DeepSkyBlue), DeepSkyBlue },
            { nameof(DimGray), DimGray },
            { nameof(DimGrey), DimGrey },
            { nameof(DodgerBlue), DodgerBlue },
            { nameof(FireBrick), FireBrick },
            { nameof(FloralWhite), FloralWhite },
            { nameof(ForestGreen), ForestGreen },
            { nameof(Fuchsia), Fuchsia },
            { nameof(Gainsboro), Gainsboro },
            { nameof(GhostWhite), GhostWhite },
            { nameof(Gold), Gold },
            { nameof(Goldenrod), Goldenrod },
            { nameof(Gray), Gray },
            { nameof(Green), Green },
            { nameof(GreenYellow), GreenYellow },
            { nameof(Grey), Grey },
            { nameof(HoneyDew), HoneyDew },
            { nameof(HotPink), HotPink },
            { nameof(IndianRed), IndianRed },
            { nameof(Indigo), Indigo },
            { nameof(Ivory), Ivory },
            { nameof(Khaki), Khaki },
            { nameof(Lavender), Lavender },
            { nameof(LavenderBlush), LavenderBlush },
            { nameof(LawnGreen), LawnGreen },
            { nameof(LemonChiffon), LemonChiffon },
            { nameof(LightBlue), LightBlue },
            { nameof(LightCoral), LightCoral },
            { nameof(LightCyan), LightCyan },
            { nameof(LightGoldenrodYellow), LightGoldenrodYellow },
            { nameof(LightGray), LightGray },
            { nameof(LightGreen), LightGreen },
            { nameof(LightGrey), LightGrey },
            { nameof(LightPink), LightPink },
            { nameof(LightSalmon), LightSalmon },
            { nameof(LightSeaGreen), LightSeaGreen },
            { nameof(LightSkyBlue), LightSkyBlue },
            { nameof(LightSlateGray), LightSlateGray },
            { nameof(LightSlateGrey), LightSlateGrey },
            { nameof(LightSteelBlue), LightSteelBlue },
            { nameof(LightYellow), LightYellow },
            { nameof(Lime), Lime },
            { nameof(LimeGreen), LimeGreen },
            { nameof(Linen), Linen },
            { nameof(Magenta), Magenta },
            { nameof(Maroon), Maroon },
            { nameof(MediumAquamarine), MediumAquamarine },
            { nameof(MediumBlue), MediumBlue },
            { nameof(MediumOrchid), MediumOrchid },
            { nameof(MediumPurple), MediumPurple },
            { nameof(MediumSeaGreen), MediumSeaGreen },
            { nameof(MediumSlateBlue), MediumSlateBlue },
            { nameof(MediumSpringGreen), MediumSpringGreen },
            { nameof(MediumTurquoise), MediumTurquoise },
            { nameof(MediumVioletRed), MediumVioletRed },
            { nameof(MidnightBlue), MidnightBlue },
            { nameof(MintCream), MintCream },
            { nameof(MistyRose), MistyRose },
            { nameof(Moccasin), Moccasin },
            { nameof(NavajoWhite), NavajoWhite },
            { nameof(Navy), Navy },
            { nameof(OldLace), OldLace },
            { nameof(Olive), Olive },
            { nameof(OliveDrab), OliveDrab },
            { nameof(Orange), Orange },
            { nameof(OrangeRed), OrangeRed },
            { nameof(Orchid), Orchid },
            { nameof(PaleGoldenrod), PaleGoldenrod },
            { nameof(PaleGreen), PaleGreen },
            { nameof(PaleTurquoise), PaleTurquoise },
            { nameof(PaleVioletRed), PaleVioletRed },
            { nameof(PapayaWhip), PapayaWhip },
            { nameof(PeachPuff), PeachPuff },
            { nameof(Peru), Peru },
            { nameof(Pink), Pink },
            { nameof(Plum), Plum },
            { nameof(PowderBlue), PowderBlue },
            { nameof(Purple), Purple },
            { nameof(RebeccaPurple), RebeccaPurple },
            { nameof(Red), Red },
            { nameof(RosyBrown), RosyBrown },
            { nameof(RoyalBlue), RoyalBlue },
            { nameof(SaddleBrown), SaddleBrown },
            { nameof(Salmon), Salmon },
            { nameof(SandyBrown), SandyBrown },
            { nameof(SeaGreen), SeaGreen },
            { nameof(SeaShell), SeaShell },
            { nameof(Sienna), Sienna },
            { nameof(Silver), Silver },
            { nameof(SkyBlue), SkyBlue },
            { nameof(SlateBlue), SlateBlue },
            { nameof(SlateGray), SlateGray },
            { nameof(SlateGrey), SlateGrey },
            { nameof(Snow), Snow },
            { nameof(SpringGreen), SpringGreen },
            { nameof(SteelBlue), SteelBlue },
            { nameof(Tan), Tan },
            { nameof(Teal), Teal },
            { nameof(Thistle), Thistle },
            { nameof(Tomato), Tomato },
            { nameof(Turquoise), Turquoise },
            { nameof(Violet), Violet },
            { nameof(Wheat), Wheat },
            { nameof(White), White },
            { nameof(WhiteSmoke), WhiteSmoke },
            { nameof(Yellow), Yellow },
            { nameof(YellowGreen), YellowGreen },
        };
}