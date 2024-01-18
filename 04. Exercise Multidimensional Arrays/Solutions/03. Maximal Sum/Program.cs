ushort[] matrixSize = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(ushort.Parse).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] row = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = row[j];
}

int highestSum = int.MinValue;
uint hieghesSumMatrixRow = 0;
uint hieghesSumMatrixColumn = 0;
for (uint i = 0; i < matrix.GetLength(0) - 2; i++)
    for (uint j = 0; j < matrix.GetLength(1) - 2; j++)
    {
        int sum = 0;
        for (int k = 0; k < 3; k++) for (int l = 0; l < 3; l++)sum += matrix[i + k, j + l];

        if (sum > highestSum)
        {
            highestSum = sum;
            hieghesSumMatrixRow = i;
            hieghesSumMatrixColumn = j;
        }
    }

Console.WriteLine($"Sum = {highestSum}");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)Console.Write(matrix[hieghesSumMatrixRow + i, hieghesSumMatrixColumn + j] + " ");
    Console.WriteLine();
}