Dictionary<int, uint> numbers = new(); //int -> number, uint -> times appeared

ushort inputNumbersCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputNumbersCount; i++)
{
    int number = int.Parse(Console.ReadLine()!);

    numbers.TryAdd(number, 0);
    numbers[number]++;
}

foreach (var number in numbers.Where( number => number.Value % 2 == 0)) Console.WriteLine(number.Key);