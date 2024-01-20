HashSet<string> uniqueElements = new();
for (int i = 0; i < byte.Parse(Console.ReadLine()!); i++) 
    foreach (string element in Console.ReadLine()!.Split()) uniqueElements.Add(element); // The input is a name
Console.WriteLine(string.Join(" ", uniqueElements));