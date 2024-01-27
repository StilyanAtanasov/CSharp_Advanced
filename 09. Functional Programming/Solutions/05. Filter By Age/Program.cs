Dictionary<string, byte> people = new(); // Name, Age

ushort peopleCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < peopleCount; i++)
{
    string[] person = Console.ReadLine()!.Split(", ");
    people.Add(person[0], byte.Parse(person[1]));
}

string wantedCondition = Console.ReadLine()!;
int givenThreshold = int.Parse(Console.ReadLine()!);

bool CreateFilter(string condition, int threshold, byte current)
{
    switch (condition)
    {
        case "older": return current >= threshold;
        case "younger": return current < threshold;
        default: return false;
    }
}

people = people.Where(x => CreateFilter(wantedCondition, givenThreshold, x.Value)).ToDictionary(x => x.Key, x => x.Value);

string outputFormat = Console.ReadLine()!;
void PrintInFormat(string format, Dictionary<string, byte> dictionary)
{
    switch (format)
    {
        case "name":
            foreach (var pair in dictionary) Console.WriteLine(pair.Key);
            break;
        case "age":
            foreach (var pair in dictionary) Console.WriteLine(pair.Value);
            break;
        case "name age":
            foreach (var pair in dictionary) Console.WriteLine($"{pair.Key} - {pair.Value}");
            break;
    }
}

PrintInFormat(outputFormat, people);