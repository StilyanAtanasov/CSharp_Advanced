namespace Custom_Linked_List_Of_Int32;

public class CustomLinkedListOfInt32
{
    private int _count;

    public Node? Head { get; set; }
    public Node? Tail { get; set; }

    public int Count => _count;

    public void AddFirst(int value)
    {
        Node node = new(value);

        if (Head == null) HandleEmptyObject(node);
        else
        {
            Head!.Previous = node;
            node.Next = Head;
            Head = node;
        }

        _count++;
    }

    public int RemoveFirst()
    {
        int oldHead;
        if (Head != null)
        {
            oldHead = Head.Value;
            if (Head.Next != null)
            {
                Head.Next.Previous = null;
                Head = Head.Next;
            }
            else HandleOnlyElementOnRemove();
        }
        else throw new InvalidOperationException("The collection list is empty!");

        _count--;
        return oldHead;
    }

    public void AddLast(int value)
    {
        Node node = new(value);

        if (Head == null) HandleEmptyObject(node);
        else
        {
            Tail!.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        _count++;
    }

    public int RemoveLast()
    {
        int oldTail;
        if (Head != null)
        {
            oldTail = Head.Value;
            if (Tail!.Previous != null)
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
            else HandleOnlyElementOnRemove();
        }
        else throw new InvalidOperationException("The collection list is empty!");

        _count--;
        return oldTail;
    }

    public void ForEach(Action<int> action)
    {
        Node? current = Head;
        while (current != null)
        {
            action(current.Value);
            current = current.Next;
        }
    }

    public int[] ToArray()
    {
        int[] array = new int[_count];
        int index = 0;

        ForEach(e => array[index++] = e);

        return array;
    }

    private void HandleEmptyObject(Node node)
    {
        Head = node;
        Tail = node;
    }

    private void HandleOnlyElementOnRemove()
    {
        Head = null;
        Tail = null;
    }
}