// ReSharper disable CheckNamespace
// ReSharper disable FieldCanBeMadeReadOnly.Local
namespace GenericScale;

public class EqualityScale<T>
{
    private T _left;
    private T _right;

    public EqualityScale(T left, T right)
    {
        _left = left;
        _right = right;
    }

    public bool AreEqual() => _left!.Equals(_right);
}