HashSet<string> uniqueNames = new();

byte namesCount = byte.Parse(Console.ReadLine()!);
for (int i = 0; i < namesCount; i++) uniqueNames.Add(Console.ReadLine()!); // The input is a name

Console.WriteLine(string.Join("\n", uniqueNames));