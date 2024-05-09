int[] array = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

QuickSort(array, 0, array.Length - 1);
Console.WriteLine(string.Join(" ", array));

int Partition(int[] arr, int lowBound, int highBound)
{
    int pivotValue = arr[highBound];
    int lastSmallerElementIndex = lowBound - 1;

    for (int i = lowBound; i < highBound; i++)
        if (arr[i] < pivotValue) (arr[i], arr[++lastSmallerElementIndex]) = (arr[lastSmallerElementIndex], arr[i]);

    (arr[highBound], arr[lastSmallerElementIndex + 1]) = (arr[lastSmallerElementIndex + 1], arr[highBound]);

    return ++lastSmallerElementIndex;
}

void QuickSort(int[] arr, int lowBound, int highBound)
{
    if (lowBound >= highBound) return;

    int lastSmallerElementIndex = Partition(arr, lowBound, highBound);

    QuickSort(arr, lowBound, lastSmallerElementIndex - 1);
    QuickSort(arr, lastSmallerElementIndex + 1, highBound);
}