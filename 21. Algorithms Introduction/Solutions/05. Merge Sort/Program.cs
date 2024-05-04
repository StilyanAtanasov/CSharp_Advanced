int[] array = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Console.WriteLine(string.Join(' ', MergeSort(array)));

int[] MergeSort(int[] arr)
{
    if (arr.Length == 1) return arr;

    int[] leftArr = MergeSort(arr[..(arr.Length / 2)]);
    int[] rightArr = MergeSort(arr[(arr.Length / 2)..]);

    int leftArrIndex = 0, rightArrIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (leftArrIndex < leftArr.Length && (rightArrIndex >= rightArr.Length || leftArr[leftArrIndex] <= rightArr[rightArrIndex]))
            arr[i] = leftArr[leftArrIndex++];
        else arr[i] = rightArr[rightArrIndex++];
    }

    return arr;
}