List<string> people = Console.ReadLine()!.Split().ToList();

Dictionary<string, Predicate<string>> filters = new();
string command = Console.ReadLine()!;
while (command != "Print")
{
    Predicate<string> filter = null!;

    string[] operation = command.Split(';');
    string modifier = operation[0];
    string key = operation[1];
    string value = operation[2];
    switch (key)
    {
        case "Starts with":
            filter = s => s[..value.Length] == value;
            break;
        case "Ends with":
            filter = s => s[^value.Length..] == value;
            break;
        case "Length":
            filter = s => s.Length == int.Parse(value);
            break;
        case "Contains":
            filter = s => s.Contains(value);
            break;
    }

    switch (modifier)
    {
        case "Add filter":
            filters.Add(key + value, filter);
            break;
        case "Remove filter":
            filters.Remove(key + value);
            break;
    }

    command = Console.ReadLine()!;
}

foreach (var filter in filters) people.RemoveAll(filter.Value);
Console.WriteLine(string.Join(' ', people));