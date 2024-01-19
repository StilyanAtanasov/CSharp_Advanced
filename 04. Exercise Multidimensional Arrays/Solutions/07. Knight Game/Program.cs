byte squareMatrixSize = byte.Parse(Console.ReadLine()!);
char[,] squareMatrix = new char[squareMatrixSize, squareMatrixSize];

for (byte i = 0; i < squareMatrixSize; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (byte j = 0; j < squareMatrixSize; j++) squareMatrix[i, j] = row[j];
}

ushort knightsRemoved = 0;
for (int max = 8; max > 0; max--)
{
    Dictionary<string, ushort> knights = new(); // string => "knightRow, knightColumn"; int => number of attacks received;
    for (int i = 0; i < squareMatrixSize; i++)
    {
        for (int j = 0; j < squareMatrixSize; j++)
        {
            if (squareMatrix[i, j] == 'K')
            {
                string[] moves =
                {
                    $"{i + 2} {j + 1}", $"{i + 2} {j - 1}", $"{i - 2} {j + 1}", $"{i - 2} {j - 1}",
                    $"{i + 1} {j + 2}", $"{i + 1} {j - 2}", $"{i - 1} {j + 2}", $"{i - 1} {j - 2}"
                };

                foreach (string move in moves)
                {
                    int y = int.Parse(move.Split()[1]);
                    int x = int.Parse(move.Split()[0]);
                    if (y >= 0 && y < squareMatrixSize && x >= 0 && x < squareMatrixSize && squareMatrix[y, x] == 'K')
                    {
                        if (knights.ContainsKey($"{y} {x}")) knights[$"{y} {x}"]++;
                        else knights.Add($"{y} {x}", 1);
                    }

                }
            }
        }
    }

    var orderedKnights = knights.OrderByDescending(x => x.Value);
    var firstKnight = orderedKnights.FirstOrDefault();

    if (firstKnight.Value == max)
    {
        string knightToRemove = firstKnight.Key;
        squareMatrix[int.Parse(knightToRemove.Split()[0]), int.Parse(knightToRemove.Split()[1])] = '0';
        knightsRemoved++;
    }

}

Console.WriteLine(knightsRemoved);