using System.Collections;

namespace _03._Stack;

public class Stack<T> : IEnumerable<T>
{
    private const int InitialCapacity = 4;
    private T[] _stack = new T[InitialCapacity];

    public int Count { get; set; }

    /// <summary> Adds an element on the top </summary>
    /// <param name="element"></param>
    public void Push(T element)
    {
        if (Count != _stack.Length)
        {
            _stack[Count] = element;
            Count++;
        }
        else
        {
            T[] newStack = new T[InitialCapacity * 2];
            for (int i = 0; i < Count; i++) newStack[i] = _stack[i];
            _stack = newStack;
        }
    }

    /// <summary> Removes and returns the top element </summary>
    public T Pop()
    {
        if (Count == 0) throw new InvalidOperationException("The stack is empty!");
        return _stack[--Count];
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Count - 1; i >= 0; i--) yield return _stack[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}