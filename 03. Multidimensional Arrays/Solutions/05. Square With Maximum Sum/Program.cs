uint[] matrixSize = Console.ReadLine()!.Split(", ").Select(uint.Parse).ToArray();
int[,] matrix = new int[matrixSize[0], matrixSize[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] row = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = row[j];
}

int highestSum = int.MinValue;
int[] highestSumMatrixIndexes = new int[2];
for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int sum = 0;
        for (int k = 0; k < 2; k++) for (int l = 0; l < 2; l++) sum += matrix[i + k, j + l];

        if (sum > highestSum)
        {
            highestSum = sum;
            highestSumMatrixIndexes[0] = i;
            highestSumMatrixIndexes[1] = j;
        }
    }

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++) Console.Write(matrix[highestSumMatrixIndexes[0] + i, highestSumMatrixIndexes[1] + j] + " ");
    Console.WriteLine();
}

Console.WriteLine(highestSum);