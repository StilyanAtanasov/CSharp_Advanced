string wordPath = @"..\..\..\Files\words.txt";
string textPath = @"..\..\..\Files\text.txt";
string outputPath = @"..\..\..\Files\output.txt";

CalculateWordCounts(wordPath, textPath, outputPath);

static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
{
    StreamReader wordsReader = new StreamReader(wordsFilePath);
    Dictionary<string, ushort> wordCounts = new Dictionary<string, ushort>();
    foreach (string word in wordsReader.ReadToEnd().Split()) wordCounts.Add(word, 0);

    StreamReader textReader = new StreamReader(textFilePath);
    while (!textReader.EndOfStream)
    {
        List<string> rowText = textReader.ReadLine()!.ToLower().Split(new[] { ' ', ',', '.', ';', ':', '!', '?', '-' }).ToList();
        foreach (string key in wordCounts.Keys)
        {
            while (rowText.Contains(key))
            {
                wordCounts[key]++;
                rowText.RemoveAt(rowText.IndexOf(key));
            }
        }
        
    }

    StreamWriter writer = new StreamWriter(outputFilePath);
    foreach (var (word, timesAppeared) in wordCounts.OrderByDescending(x => x.Value)) writer.WriteLine($"{word} - {timesAppeared}");
    writer.Close();
}