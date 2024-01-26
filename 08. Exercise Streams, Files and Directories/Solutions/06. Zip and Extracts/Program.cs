using System.IO.Compression;

string inputFile = @"..\..\..\copyMe.png";
string zipArchiveFile = @"..\..\..\archive.zip";
string extractedFile = @"..\..\..\extracted.png";

ZipFileToArchive(inputFile, zipArchiveFile);

var fileNameOnly = Path.GetFileName(inputFile);
ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);


static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
{
   using ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);
   archive.CreateEntryFromFile(inputFilePath, Path.GetFileName(inputFilePath));
}

static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
{
    using ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Read);
    archive.GetEntry(fileName)!.ExtractToFile(outputFilePath);
}