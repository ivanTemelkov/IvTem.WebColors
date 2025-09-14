namespace IvTem.WebColors.Feature;

public abstract class ComputedColorResult
{
    public bool IsSuccess { get; }

    protected ComputedColorResult(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
}