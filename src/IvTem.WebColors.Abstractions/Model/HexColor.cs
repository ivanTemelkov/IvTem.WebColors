namespace IvTem.WebColors.Abstractions.Model;

public record HexColor(string Hex) : IWebColor
{
    public string Stringify() 
        => Hex;
}