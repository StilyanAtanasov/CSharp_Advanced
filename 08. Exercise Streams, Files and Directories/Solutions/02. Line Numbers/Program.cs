string inputFilePath = @"..\..\..\text.txt";
string outputFilePath = @"..\..\..\output.txt";

ProcessLines(inputFilePath, outputFilePath);

static void ProcessLines(string inputFilePath, string outputFilePath)
{
    File.WriteAllText(outputFilePath, "");

    string[] lines = File.ReadAllLines(inputFilePath);

    char[] punctuationMarks = { '-', ',', '.', '!', '?', '\'', '"' };
    for (int i = 0; i < lines.Length; i++)
    {
        string temp = lines[i];
        ulong punctuationMarksCount = 0;

        foreach (char punctuationMark in punctuationMarks)
        {
            ulong tempLength = (ulong) temp.Length;
            temp = temp.Replace(Convert.ToString(punctuationMark), "");
            punctuationMarksCount += tempLength - (ulong) temp.Length;
        }

        temp = temp.Replace(" ", "");
        uint lettersCount = (uint)temp.Length;

        File.AppendAllText(outputFilePath, $"Line {i + 1}: {lines[i]} ({lettersCount})({punctuationMarksCount})" + '\n');
    }
}