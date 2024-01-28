int end = int.Parse(Console.ReadLine()!);
List<int> numbers = Enumerable.Range(1, end).ToList();
List<int> dividers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

foreach (int divider in dividers)
{
    // ReSharper disable once ConvertToLocalFunction
    Predicate<int> isMultiple = x => x % divider == 0;
    numbers = numbers.Where(x => isMultiple(x)).ToList();
}

Console.WriteLine(string.Join(' ', numbers));