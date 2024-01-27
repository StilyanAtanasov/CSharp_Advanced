int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).Reverse().ToArray();
int divider = int.Parse(Console.ReadLine()!);

// ReSharper disable once ConvertToLocalFunction
Predicate<int> isMultiple = multiple => multiple % divider != 0;
Console.WriteLine(string.Join(' ', numbers.Where(x => isMultiple(x))));