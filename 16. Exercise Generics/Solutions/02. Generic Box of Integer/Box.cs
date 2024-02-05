namespace _02._Generic_Box_of_Integer;
public class Box<T>
{
    private T _value;

    public Box(T value) => _value = value;

    public override string ToString() => $"{_value!.GetType()}: {_value}";
}