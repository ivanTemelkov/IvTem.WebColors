namespace IvTem.WebColors.Abstractions.Feature.ColorService;

public interface IWebColorService
{
    ValueTask<WebColorResult> GetColor(string colorString);
}