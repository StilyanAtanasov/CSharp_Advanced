namespace CustomDoublyLinkedList;

public class DoublyLinkedList<T>
{
    private int _count;

    public Node<T>? Head { get; set; }
    public Node<T>? Tail { get; set; }

    public int Count => _count;

    public void AddFirst(T value)
    {
        Node<T> node = new(value);

        if (Head == null) HandleEmptyObject(node);

        Head!.Previous = node;
        node.Next = Head;
        Head = node;

        _count++;
    }

    public T RemoveFirst()
    {
        T oldHead;
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

    public void AddLast(T value)
    {
        Node<T> node = new(value);

        if (Head == null) HandleEmptyObject(node);

        Tail!.Next = node;
        node.Previous = Tail;
        Tail = node;

        _count++;
    }

    public T RemoveLast()
    {
        T oldTail;
        if (Tail != null)
        {
            oldTail = Tail.Value;
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

    public void ForEach(Action<T> action)
    {
        Node<T>? current = Head;
        while (current != null)
        {
            action(current.Value);
            current = current.Next;
        }
    }

    public T[] ToArray()
    {
        T[] array = new T[_count];
        int index = 0;

        ForEach(e => array[index++] = e);

        return array;
    }

    private void HandleEmptyObject(Node<T> node)
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