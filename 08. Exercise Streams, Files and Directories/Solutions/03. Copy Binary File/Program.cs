string inputFilePath = @"..\..\..\copyMe.png";
string outputFilePath = @"..\..\..\copyMe-copy.png";

CopyFile(inputFilePath, outputFilePath);

static void CopyFile(string inputFilePath, string outputFilePath)
{
    using FileStream inputFile = new(inputFilePath, FileMode.Open);
    using FileStream outputFile = new(outputFilePath, FileMode.Create);

    byte[] buffer = new byte[1024];
    while (inputFile.Read(buffer) != 0) outputFile.Write(buffer);
}