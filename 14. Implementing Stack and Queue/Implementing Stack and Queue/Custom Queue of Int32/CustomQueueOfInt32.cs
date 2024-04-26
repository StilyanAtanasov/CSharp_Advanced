namespace Custom_Queue_of_Int32;

public class CustomQueueOfInt32
{
    private const int InitialCapacity = 4;
    private int[] items;

    public CustomQueueOfInt32()
    {
        items = new int[InitialCapacity];
        Count = 0;
    }

    public int Count { get; private set; }

    public void Enqueue(int item)
    {
        if (Count == items.Length) DoubleArraySize();
        items[Count] = item;
        Count++;
    }

    public int Dequeue()
    {
        HandleIfTheArrayIsEmpty();
        int firstElement = items[0];
        Count--;
        ShiftArrayLeftOnce();
        return firstElement;
    }

    public int Peek()
    {
        HandleIfTheArrayIsEmpty();
        return items[0];
    }

    public void Clear()
    {
        HandleIfTheArrayIsEmpty();
        Count = 0;
    }

    public void ForEach(Action<object> action)
    {
        for (int i = 0; i < Count; i++) action(items[i]);
    }

    private void DoubleArraySize()
    {
        int[] newArray = new int[items.Length * 2];
        for (int i = 0; i < Count; i++) newArray[i] = items[i];

        items = newArray;
    }

    private void ShiftArrayLeftOnce()
    {
        for (int i = 0; i < Count; i++) items[i] = items[i + 1];
    }

    private void HandleIfTheArrayIsEmpty()
    {
        if (Count == 0) throw new InvalidOperationException("Queue empty!");
    }
}