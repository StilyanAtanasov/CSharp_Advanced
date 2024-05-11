int[] array = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

QuickSort(array, 0, array.Length - 1);
Console.WriteLine(string.Join(" ", array));

int Partition(int[] arr, int lowBound, int highBound, int pivot)
{
    while (lowBound <= highBound)
    {
        while (arr[lowBound] < pivot) lowBound++;
        while (arr[highBound] > pivot) highBound--;

        if (lowBound <= highBound) (arr[lowBound], arr[highBound]) = (arr[highBound--], arr[lowBound++]);
    }

    return lowBound;
}

void QuickSort(int[] arr, int lowBound, int highBound)
{
    if (lowBound >= highBound) return;

    int pivot = arr[(lowBound + highBound) / 2];
    int index = Partition(arr, lowBound, highBound, pivot);

    QuickSort(arr, lowBound, index - 1);
    QuickSort(arr, index, highBound);
}