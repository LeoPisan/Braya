namespace Braya.Data;

public abstract class AbstractData<T>
{
    private T key;

    public abstract bool IsGreaterThan(T comparedValue);
}