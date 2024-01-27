int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

// ReSharper disable once ConvertToLocalFunction
Func<int[], int> findMinNumber = array =>
{
    int min = Int32.MaxValue;
    foreach (int i in array) min = min < i ? min : i;
    return min;
};

Console.WriteLine(findMinNumber(numbers));