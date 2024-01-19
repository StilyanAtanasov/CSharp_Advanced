ushort[] matrixSize = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(ushort.Parse).ToArray();
char[,] matrix = new char[matrixSize[0], matrixSize[1]];

string snake = Console.ReadLine()!;
ulong counter = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i % 2 == 0) for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (counter >= (ulong)snake.Length) counter -= (ulong)snake.Length;
        matrix[i, j] = snake[(int)counter];
        counter++;
    }
    else for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
    {
        if (counter >= (ulong)snake.Length) counter -= (ulong)snake.Length;
        matrix[i, j] = snake[(int)counter];
        counter++;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++) Console.Write(matrix[i, j]);
    Console.WriteLine();
}