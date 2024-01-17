ushort squareMatrixSize = ushort.Parse(Console.ReadLine()!);
char[,] squareMatrix = new char[squareMatrixSize, squareMatrixSize];

for (int i = 0; i < squareMatrixSize; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (int j = 0; j < squareMatrixSize; j++) squareMatrix[i, j] = row[j];
}

char symbol = char.Parse(Console.ReadLine()!);
for (int i = 0; i < squareMatrixSize; i++) for (int j = 0; j < squareMatrixSize; j++)
    if (squareMatrix[i, j] == symbol)
    {
            Console.WriteLine($"({i}, {j})");
            return;
    }

Console.WriteLine($"{symbol} does not occur in the matrix");