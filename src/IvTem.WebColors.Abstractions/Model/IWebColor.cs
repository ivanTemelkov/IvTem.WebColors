namespace IvTem.WebColors.Abstractions.Model;

public interface IWebColor
{
    public bool IsLight { get; }
    string Stringify();
}