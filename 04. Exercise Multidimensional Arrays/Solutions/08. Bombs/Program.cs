uint squareMatrixSize = uint.Parse(Console.ReadLine()!);

int[,] squareMatrix = new int[squareMatrixSize, squareMatrixSize];
for (int i = 0; i < squareMatrixSize; i++)
{
    int[] row = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    for (int j = 0; j < squareMatrixSize; j++) squareMatrix[i, j] = row[j];
}

ushort bombRange = 1; // To be read by the console for more scalable functionality

string[] bombsPositions = Console.ReadLine()!.Split();
foreach (string bombsPosition in bombsPositions)
{
    int[] positionCoordinates = bombsPosition.Split(',').Select(int.Parse).ToArray();
    int row = positionCoordinates[0];
    int column = positionCoordinates[1];

    if (squareMatrix[row, column] <= 0) continue;

    List<int[]> positionsToBeBombed = new();
    for (int i = 1; i <= bombRange; i++)
    {
        // Calculate direct neighbours
        int rowUp = row - i;
        int rowDown = row + i;
        int columnUp = column + i;
        int columnDown = column - i;

        if (rowUp >= 0) positionsToBeBombed.Add(new[] { rowUp, column });
        if (rowDown < squareMatrixSize) positionsToBeBombed.Add(new[] { rowDown, column });
        if (columnUp < squareMatrixSize) positionsToBeBombed.Add(new[] { row, columnUp });
        if (columnDown >= 0) positionsToBeBombed.Add(new[] { row, columnDown });

        // Calculate side neighbours
        for (int j = 1; j <= bombRange; j++)
        {
            if (column + j < squareMatrixSize && rowUp >= 0) positionsToBeBombed.Add(new[] { rowUp, column + j });
            if (column - j >= 0 && rowDown < squareMatrixSize) positionsToBeBombed.Add(new[] { rowDown, column - j });
            if (row + j < squareMatrixSize && columnUp < squareMatrixSize) positionsToBeBombed.Add(new[] { row + j, columnUp });
            if (row - j >= 0 && columnDown >= 0) positionsToBeBombed.Add(new[] { row - j, columnDown });
        }
    }

    foreach (int[] position in positionsToBeBombed)
    {
        int bombedRowCoordinate = position[0];
        int bombedColumnCoordinate = position[1];
        if (squareMatrix[bombedRowCoordinate, bombedColumnCoordinate] > 0)
            squareMatrix[bombedRowCoordinate, bombedColumnCoordinate] -= squareMatrix[row, column];
    }

    squareMatrix[row, column] = 0;
}

int aliveCellsCount = 0;
int aliveCellsSum = 0;
for (int i = 0; i < squareMatrixSize; i++)
{
    for (int j = 0; j < squareMatrixSize; j++)
    {
        if (squareMatrix[i, j] > 0)
        {
            aliveCellsCount++;
            aliveCellsSum += squareMatrix[i, j];
        }
    }
}

Console.WriteLine($"Alive cells: {aliveCellsCount}");
Console.WriteLine($"Sum: {aliveCellsSum}");
for (int i = 0; i < squareMatrixSize; i++)
{
    for (int j = 0; j < squareMatrixSize; j++) Console.Write($"{squareMatrix[i, j]} ");
    Console.WriteLine();
}