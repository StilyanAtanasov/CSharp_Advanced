SortedDictionary<char, uint> symbols = new(); //int -> symbol, uint -> times appeared

string text = Console.ReadLine()!;
foreach (char current in text)
{
    if (!symbols.ContainsKey(current)) symbols[current] = 0;
    symbols[current]++;
}

foreach (var number in symbols) Console.WriteLine($"{number.Key}: {number.Value} time/s");