namespace AuthService.Domain.Common;

public class Result<TValue>
{
    private readonly TValue? _value;
    private readonly Error _error;
    
    private readonly bool _isSuccess;

    public Result(TValue value)
    {
        _isSuccess = true;
        _value = value;
        _error = Error.None;
    }

    public Result(Error error)
    {
        _isSuccess = false;
        _value = default;
        _error = error;
    }

    public static Result<TValue> Success(TValue value) =>
        new(value);

    public static Result<TValue> Failure(Error error) =>
        new(error);

    public static implicit operator Result<TValue>(TValue value) =>
        new(value);

    public static implicit operator Result<TValue>(Error error) =>
        new(error);

    public TResult Match<TResult>(
        Func<TValue, TResult> onSuccess,
        Func<Error, TResult> onFailure)
    {
        return _isSuccess ? onSuccess(_value!) : onFailure(_error);
    }

    public bool IsSuccess => _isSuccess;
    public TValue? Value => _isSuccess ? _value! : throw new InvalidOperationException("Failed result doesn't have value");
    public Error Error => !_isSuccess ? _error : Error.None;
}