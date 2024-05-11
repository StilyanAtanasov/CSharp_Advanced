int[] array = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int wantedNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine(FindNumberIndex(array, wantedNumber, 0, array.Length - 1));

int FindNumberIndex(int[] arr, int wantedNum, int start, int end)
{
    if (start > end) return -1;

    int centerIndex = (start + end) / 2;
    if (arr[centerIndex] == wantedNum) return centerIndex;
    if (arr[centerIndex] > wantedNum) return FindNumberIndex(arr, wantedNum, start, centerIndex - 1);
    return FindNumberIndex(arr, wantedNum, centerIndex + 1, end);
}