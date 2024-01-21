Dictionary<string, Dictionary<string, ushort>> wardrobe = new(); //color, clothName, count

ushort inputLines = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputLines; i++)
{
    string[] row = Console.ReadLine()!.Split(new[]{ " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = row[0];

    if (!wardrobe.ContainsKey(color)) wardrobe[color] = new Dictionary<string, ushort>();
    foreach (string cloth in row[1..])
    {
        if (!wardrobe[color].ContainsKey(cloth)) wardrobe[color][cloth] = 0;
        wardrobe[color][cloth]++;
    }
}

string[] wanted = Console.ReadLine()!.Split(); // color, cloth
foreach (var (color, clothes) in wardrobe)
{
    Console.WriteLine($"{color} clothes:");
    foreach (var (clothe, count) in clothes)
    {
        Console.Write($"* {clothe} - {count}");
        if (clothe == wanted[1] && color == wanted[0]) Console.Write(" (found!)");
        Console.WriteLine();
    }
}