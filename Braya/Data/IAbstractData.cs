namespace Braya.Data;

/// <summary>
/// Represents a data stored in a tree
/// </summary>
/// <typeparam name="T">The raw type of the data</typeparam>
public interface IAbstractData<T>
{
    /// <summary>
    /// The stored data
    /// </summary>
    public T Data { get; }
    
    /// <summary>
    /// Compares the value of the stored data with another one
    /// </summary>
    /// <param name="comparedValue">The object with which the stored data is compared to</param>
    /// <returns>True if that object is greater than the one it is compared to</returns>
    public abstract bool IsGreaterThan(IAbstractData<T> comparedValue);
    
    public bool Equals(IAbstractData<T> comparedValue);
}