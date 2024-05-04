int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Console.WriteLine(ArraySumCalculator(array));

int ArraySumCalculator(int[] arr)
{
    if (arr.Length == 1) return arr[0];
    return arr[0] + ArraySumCalculator(arr[1..]);
}