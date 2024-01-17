ushort squareMatrixSize = ushort.Parse(Console.ReadLine()!);
int[,]  squareMatrix = new int[squareMatrixSize, squareMatrixSize];

for (int i = 0; i < squareMatrixSize; i++)
{
    int[] row = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    for (int j = 0; j < squareMatrixSize; j++) squareMatrix[i, j] = row[j];
}

int sum = 0;
for (int i = 0; i < squareMatrixSize; i++) sum += squareMatrix[i, i];

Console.WriteLine(sum);