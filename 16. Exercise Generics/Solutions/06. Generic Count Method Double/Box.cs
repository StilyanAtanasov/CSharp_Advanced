namespace _06._Generic_Count_Method_Double;

public class Box<T> where T : IComparable<T>
{
    public List<T> List { get; set; } = new();

    public static int ValidElementsCount(List<T> list, T comparer)
    {
        int count = 0;
        foreach (T element in list) if (element.CompareTo(comparer) > 0) count++;

        return count;
    }
}