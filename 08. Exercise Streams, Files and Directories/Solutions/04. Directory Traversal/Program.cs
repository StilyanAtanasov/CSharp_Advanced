using System.Text;

string path = Console.ReadLine()!;
string reportFileName = @"\report.txt";

string reportContent = TraverseDirectory(path);
Console.WriteLine(reportContent);

WriteReportToDesktop(reportContent, reportFileName);


static string TraverseDirectory(string inputFolderPath)
{
    Dictionary<string, Dictionary<string, long>> dirInfo = new(); // group by extension, name and size

    string[] files = Directory.GetFiles(inputFolderPath);

    foreach (string file in files)
    {
        FileInfo info = new FileInfo(file);

        if (!dirInfo.ContainsKey(info.Extension)) dirInfo[info.Extension] = new Dictionary<string, long>();
        if (!dirInfo[info.Extension].ContainsKey(info.Name)) dirInfo[info.Extension][info.Name] = info.Length;
    }

    dirInfo = dirInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ThenBy(x => x.Value.Values).ToDictionary(x => x.Key, x => x.Value);

    StringBuilder sb = new();
    foreach (var (extension, filesInfo) in dirInfo)
    {
        sb.AppendLine(extension);
        foreach (var (name, size) in filesInfo) sb.AppendLine($"--{name} - {size / 1000.0}kb");
    }

    return sb.ToString();
}

static void WriteReportToDesktop(string textContent, string reportFileName)
{
    File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/{reportFileName}", textContent);
}