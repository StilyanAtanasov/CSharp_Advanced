string inputPath = @$"{Console.ReadLine()!}";
string outputPath = @$"{Console.ReadLine()!}";

CopyAllFiles(inputPath, outputPath);

static void CopyAllFiles(string inputPath, string outputPath)
{
    if (Directory.Exists(outputPath)) Directory.Delete(outputPath, true);
    Directory.CreateDirectory(outputPath);

    string[] files = Directory.GetFiles(inputPath);
    foreach (var file in files)
    {
        FileInfo fileInfo = new(file);
        File.Copy(file, outputPath + '\\' + fileInfo.Name);
    }
}