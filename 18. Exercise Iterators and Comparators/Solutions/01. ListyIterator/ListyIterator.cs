namespace _01._ListyIterator;

public class ListyIterator<T>
{
    private readonly List<T> _list;
    private int _index;

    public ListyIterator(params T[] list) => _list = new List<T>(list);

    public bool HasNext() => _index + 1 < _list.Count;

    public bool Move()
    {
        bool isValidOperation = HasNext();
        if (isValidOperation) _index++;
        return isValidOperation;
    }

    public void Print() => Console.WriteLine(_index < _list.Count ? _list[_index] : "Invalid Operation!");
}