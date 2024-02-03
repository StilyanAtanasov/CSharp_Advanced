// ReSharper disable once CheckNamespace
namespace BoxOfT;

public class Box<T>
{

    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    private Stack<T> _list = new();
    public int Count => _list.Count;

    public void Add(T item) => _list.Push(item);
    public T Remove() => _list.Pop();
}