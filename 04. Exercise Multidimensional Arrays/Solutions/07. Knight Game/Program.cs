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
    for (int i = 0; i < squareMatrixSize; i++)
    {
        for (int j = 0; j < squareMatrixSize; j++)
        {
            byte endangered = 0;
            if (squareMatrix[i, j] == 'K')
            {
                string[] moves =
                {
                    $"{i + 2} {j + 1}", $"{i + 2} {j - 1}", $"{i - 2} {j + 1}", $"{i - 2} {j - 1}",
                    $"{i + 1} {j + 2}", $"{i + 1} {j - 2}", $"{i - 1} {j + 2}", $"{i - 1} {j - 2}"
                };

                foreach (string move in moves)
                {
                    int y = int.Parse(move.Split()[0]);
                    int x = int.Parse(move.Split()[1]);
                    if (y >= 0 && y < squareMatrixSize && x >= 0 && x < squareMatrixSize && squareMatrix[y, x] == 'K') endangered++;
                }
            }

            if (endangered == max)
            {
                squareMatrix[i, j] = '0';
                knightsRemoved++;
            }
        }
    }
}

Console.WriteLine(knightsRemoved);