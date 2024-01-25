string sourceFilePath = @"..\..\..\Files\example.png";
string joinedFilePath = @"..\..\..\Files\example-joined.png";
string partOnePath = @"..\..\..\Files\part-1.bin";
string partTwoPath = @"..\..\..\Files\part-2.bin";

SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);

static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
{
    using FileStream sourceBytes = new FileStream(sourceFilePath, FileMode.Open);
    using FileStream writer1 = new FileStream(partOneFilePath, FileMode.Create);
    using FileStream writer2 = new FileStream(partTwoFilePath, FileMode.Create);

    ulong bytesCount = (ulong) (sourceBytes.Length % 2 == 0 ? sourceBytes.Length / 2 : sourceBytes.Length / 2 + 1);

    byte[] buffer = new byte[bytesCount];
    int read = sourceBytes.Read(buffer, 0 , (int) bytesCount);
    writer1.Write(buffer, 0, read);
    read = sourceBytes.Read(buffer, 0, (int) bytesCount);
    writer2.Write(buffer, 0, read);
}

static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
{
    File.WriteAllBytes(joinedFilePath, File.ReadAllBytes(partOneFilePath).Concat(File.ReadAllBytes(partTwoFilePath)).ToArray());
}