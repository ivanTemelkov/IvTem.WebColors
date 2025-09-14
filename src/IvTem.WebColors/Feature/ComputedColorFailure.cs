namespace IvTem.WebColors.Feature;

public sealed class ComputedColorFailure : ComputedColorResult
{
    public string Reason { get; }

    public ComputedColorFailure(string reason) : base(isSuccess: false)
    {
        Reason = reason;
    }
    
}