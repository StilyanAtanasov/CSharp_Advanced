string folderPath = @"..\..\..\Files\TestFolder";
string outputPath = @"..\..\..\Files\output.txt";

GetFolderSize(folderPath, outputPath);

static void GetFolderSize(string folderPath, string outputFilePath)
{
    DirectoryInfo folderInfo = new(folderPath);
    FileInfo[] files = folderInfo.GetFiles("*", SearchOption.AllDirectories);

    ulong sum = 0;
    foreach (FileInfo file in files) sum += (ulong)file.Length;

    using StreamWriter writer = new(outputFilePath);
    writer.Write(sum / 1000.0 + " KB");
}