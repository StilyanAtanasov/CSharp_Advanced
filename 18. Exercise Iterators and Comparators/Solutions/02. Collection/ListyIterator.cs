using System.Collections;

namespace _02._Collection;

public class ListyIterator<T> : IEnumerable<T>
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

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T e in _list)  yield return e;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}