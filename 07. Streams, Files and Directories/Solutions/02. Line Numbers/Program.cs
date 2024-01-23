string inputPath = @"..\..\..\Files\input.txt";
string outputPath = @"..\..\..\Files\output.txt";

RewriteFileWithLineNumbers(inputPath, outputPath);

static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
{
    using StreamReader reader = new StreamReader(inputFilePath);
    using StreamWriter writer = new StreamWriter(outputFilePath);

    ushort index = 1;
    while (!reader.EndOfStream) writer.WriteLine($"{index++}. {reader.ReadLine()}");
}