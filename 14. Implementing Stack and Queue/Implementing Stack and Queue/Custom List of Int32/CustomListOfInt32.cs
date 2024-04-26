namespace Custom_List_of_Int32;

public class CustomListOfInt32
{
    private const int InitialCapacity = 4;
    private int[] _list;

    public CustomListOfInt32()
    {
        _list = new int[InitialCapacity];
        Count = 0;
    }

    public int Count { get; set; }

    public int this[int index]
    {
        get
        {
            HandleIfIndexIsOutOfRange(index);
            return _list[index];
        }
        set
        {
            HandleIfIndexIsOutOfRange(index);
            _list[index] = value;
        }
    }

    public void Add(int item)
    {
        EnlargeArrayIfPossible();
        _list[Count] = item;
        Count++;
    }

    public int RemoveAt(int index)
    {
        HandleIfIndexIsOutOfRange(index);
        int element = _list[index];
        _list[index] = 0;
        ShiftLeft(index);
        Count--;

        ShrinkArrayIfPossible();
        return element;
    }

    public void Insert(int index, int item)
    {
        HandleIfIndexIsOutOfRange(index);
        EnlargeArrayIfPossible();
        ShiftRight(index);

        _list[index] = item;
        Count++;
    }

    public bool Contains(int item)
    {
        for (int i = 0; i < Count; i++) if (_list[i] == item) return true;
        return false;
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        HandleIfIndexIsOutOfRange(firstIndex);
        HandleIfIndexIsOutOfRange(secondIndex);

        (_list[firstIndex], _list[secondIndex]) = (_list[secondIndex], _list[firstIndex]);
    }

    private void EnlargeArrayIfPossible()
    {
        if (Count == _list.Length)
        {
            int[] newArray = new int[_list.Length * 2];
            for (int i = 0; i < Count; i++) newArray[i] = _list[i];

            _list = newArray;
        }
    }

    private void ShrinkArrayIfPossible()
    {
        if (Count * 2 <= _list.Length)
        {
            int[] newArray = new int[_list.Length / 2];
            for (int i = 0; i < Count; i++) newArray[i] = _list[i];

            _list = newArray;
        }
    }

    private void ShiftLeft(int startingIndex)
    {
        for (int i = startingIndex; i < Count - 1; i++) _list[i] = _list[i + 1];
    }

    private void ShiftRight(int startingIndex)
    {
        for (int i = Count; i > startingIndex; i--) _list[i] = _list[i - 1];
    }

    private void HandleIfIndexIsOutOfRange(int index)
    {
        if (index >= Count || index < 0) throw new ArgumentOutOfRangeException($"Index {index} is out of range!");
    }
}