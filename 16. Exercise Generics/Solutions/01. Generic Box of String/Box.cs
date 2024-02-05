namespace _01._Generic_Box_of_String;

public class Box<T>
{
    private T _value;

    public Box(T value) => _value = value;

    public override string ToString() => $"{_value!.GetType()}: {_value}";
}