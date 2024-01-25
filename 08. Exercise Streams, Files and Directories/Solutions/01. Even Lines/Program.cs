using System.Text;

string inputFilePath = @"..\..\..\text.txt";
Console.WriteLine(ProcessLines(inputFilePath));

static string ProcessLines(string inputFilePath)
{
    List<string[]> lines = new();

    using StreamReader reader = new(inputFilePath);
    string? currentLine = reader.ReadLine();
    uint counter = 0;
    while (currentLine != null)
    {
        if (counter % 2 == 0) lines.Add(currentLine.Split());
        currentLine = reader.ReadLine();
        counter++;
    }

    char[] specialSymbols = { '-', ',', '.', '!', '?' };
    foreach (var line in lines)
    {
        for (int j = 0; j < line.Length; j++) foreach (char specialSymbol in specialSymbols) if (line[j].Contains(specialSymbol)) line[j] = line[j].Replace(specialSymbol, '@');
        Array.Reverse(line);
    }

    StringBuilder sb = new();
    foreach (string[] line in lines) sb.Append(string.Join(" ", line) + '\n');

    return sb.ToString();
}