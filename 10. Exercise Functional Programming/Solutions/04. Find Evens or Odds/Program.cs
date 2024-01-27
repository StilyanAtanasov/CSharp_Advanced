int[] range = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
List<int> integers = Enumerable.Range(range[0], range[1] - range[0] + 1).ToList();

string keyword = Console.ReadLine()!;
Predicate<int> SetFilter(string word)
{
    switch (word.ToLower())
    {
        case "odd": return x => x % 2 == 1 || x % 2 == -1;
        case "even": return x => x % 2 == 0;
        default: return null!;
    }
}

Predicate<int> filter = SetFilter(keyword);
Console.WriteLine(string.Join(' ', integers.Where(x => filter(x))));