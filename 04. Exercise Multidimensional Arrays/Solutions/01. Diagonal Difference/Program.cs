ushort squareMatrixSize = ushort.Parse(Console.ReadLine()!);
int[,] squareMatrix = new int[squareMatrixSize, squareMatrixSize];

for (int i = 0; i < squareMatrixSize; i++)
{
    int[] row = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    for (int j = 0; j < squareMatrixSize; j++) squareMatrix[i, j] = row[j];
}

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;
for (int i = 0; i < squareMatrixSize; i++)
{
    primaryDiagonalSum += squareMatrix[i, i];
    secondaryDiagonalSum += squareMatrix[i, squareMatrixSize - i - 1];
}

Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));