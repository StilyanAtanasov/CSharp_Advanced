uint[] matrixSize = Console.ReadLine()!.Split(", ").Select(uint.Parse).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] row = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = row[j];
    sum += row.Sum();
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);