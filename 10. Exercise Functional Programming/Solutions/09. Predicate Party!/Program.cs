List<string> people = Console.ReadLine()!.Split().ToList();

string command = Console.ReadLine()!;
while (command != "Party!")
{
    Predicate<string> filter = null!;

    string[] operation = command.Split();
    string modifier = operation[0];
    string key = operation[1];
    string value = operation[2];
    switch (key)
    {
        case "StartsWith":
            filter = s => s[..value.Length] == value;
            break;
        case "EndsWith":
            filter = s => s[^value.Length..] == value;
            break;
        case "Length":
            filter = s => s.Length == int.Parse(value);
            break;
    }

    switch (modifier)
    {
        case "Double":
            people.Where(x => filter(x)).ToList().ForEach(x => people.Insert(people.IndexOf(x), x));
            break;
        case "Remove":
            people.RemoveAll(filter);
            break;
    }

    command = Console.ReadLine()!;
}

Console.WriteLine(people.Count != 0 ? $"{string.Join(", ", people)} are going to the party!" : "Nobody is going to the party!");