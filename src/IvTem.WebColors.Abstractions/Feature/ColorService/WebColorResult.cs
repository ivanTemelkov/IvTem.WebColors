namespace IvTem.WebColors.Abstractions.Feature.ColorService;

public abstract class WebColorResult
{
    public bool IsSuccess { get; }

    protected WebColorResult(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
}