var firstInputFilePath = @"..\..\..\Files\input1.txt";
var secondInputFilePath = @"..\..\..\Files\input2.txt";
var outputFilePath = @"..\..\..\Files\output.txt";

MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);

static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
{
    using StreamReader file1 = new StreamReader(firstInputFilePath);
    using StreamReader file2 = new StreamReader(secondInputFilePath);
    using StreamWriter outputFile = new StreamWriter(outputFilePath);

    string? file1Row = file1.ReadLine();
    string? file2Row = file2.ReadLine();
    while (file1Row != null && file2Row != null)
    {
        outputFile.WriteLine(file1Row);
        outputFile.WriteLine(file2Row);

        file1Row = file1.ReadLine();
        file2Row = file2.ReadLine();
    }
}