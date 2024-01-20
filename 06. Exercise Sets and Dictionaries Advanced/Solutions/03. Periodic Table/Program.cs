SortedSet<string> uniqueElements = new();

byte rowsCount = byte.Parse(Console.ReadLine()!);
for (int i = 0; i < rowsCount ; i++) foreach (string element in Console.ReadLine()!.Split()) uniqueElements.Add(element); // The input is a name

Console.WriteLine(string.Join(" ", uniqueElements));