ushort[] matrixSize = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(ushort.Parse).ToArray();
char[,] matrix = new char[matrixSize[0], matrixSize[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    char[] row = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = row[j];
}

ushort squares = 0;
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        char symbol = matrix[i, j];
        ushort counter = 1;
        for (int k = 0; k < 2; k++) for (int l = 0; l < 2; l++) if (!(k == 0 && l == 0) && matrix[i + k, j + l] == symbol) counter++;

        if (counter == 4) squares++;
    }

Console.WriteLine(squares);