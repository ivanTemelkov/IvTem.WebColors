namespace IvTem.WebColors.Abstractions.Feature.ColorService;

public sealed class WebColorFailure : WebColorResult
{
    public string Reason { get; }

    public WebColorFailure(string reason) : base(isSuccess: false)
    {
        Reason = reason;
    }
    
}