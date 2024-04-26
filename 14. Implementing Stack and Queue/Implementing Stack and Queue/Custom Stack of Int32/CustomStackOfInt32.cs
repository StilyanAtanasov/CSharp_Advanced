namespace Custom_Stack_of_Int32;

public class CustomStackOfInt32
{
    private const int InitialCapacity = 4;
    private int[] _items;

    public CustomStackOfInt32()
    {
        _items = new int[InitialCapacity];
        Count = 0;
    }

    public int Count { get; private set; }

    public void Push(int element)
    {
        if (Count == _items.Length) DoubleArraySize();
        _items[Count] = element;
        Count++;
    }

    public int Pop()
    {
        if (Count == 0) HandleEmptyStack();
        Count--;
        return _items[Count];
    }

    public int Peek()
    {
        if (Count == 0) HandleEmptyStack();
        return _items[Count - 1];
    }

    public void ForEach(Action<object> action)
    {
        for (int i = 0; i < Count; i++) action(_items[i]);
    }

    private void DoubleArraySize()
    {
        int[] doubleSizedArray = new int[_items.Length * 2];
        for (int i = 0; i < Count; i++) doubleSizedArray[i] = _items[i];

        _items = doubleSizedArray;
    }

    private void HandleEmptyStack() => throw new InvalidOperationException("The stack is empty!");
}