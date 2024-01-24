string binaryFilePath = @"..\..\..\Files\example.png";
string bytesFilePath = @"..\..\..\Files\bytes.txt";
string outputPath = @"..\..\..\Files\output.bin";

ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);

static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
{
    using FileStream binaryFile = new FileStream(binaryFilePath, FileMode.Open);
    using StreamReader bytesFile = new StreamReader(bytesFilePath);
    using StreamWriter writer = new StreamWriter(outputPath);

    List<byte> bytes = new List<byte>();
    while (!bytesFile.EndOfStream) bytes.Add(byte.Parse(bytesFile.ReadLine()!));
    
    byte[] buffer = new byte[1000];
    while (true)
    {
        if (binaryFile.Read(buffer) == 0) break;

        foreach (byte b in bytes) if (buffer.Contains(b)) writer.WriteLine(b);

        binaryFile.Write(buffer, 0, buffer.Length);
    }
}