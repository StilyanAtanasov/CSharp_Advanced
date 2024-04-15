byte[] lairDimensions = Console.ReadLine()!.Split().Select(byte.Parse).ToArray();
byte lairRows = lairDimensions[0];
byte lairColumns = lairDimensions[1];

int personPositionRow = Int32.MinValue;
int personPositionColumn = Int32.MinValue;

List<int[]> bunniesCoordinates;

char[,] lair = new char[lairRows, lairColumns];
for (int i = 0; i < lairRows; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (int j = 0; j < lairColumns; j++)
    {
        lair[i, j] = row[j];
        if (lair[i, j] == 'P')
        {
            personPositionRow = i;
            personPositionColumn = j;
        }
    }
}

bool isDead = false;
char[] directions = Console.ReadLine()!.ToCharArray(); // UDRL => Up Down Right Left
foreach (char direction in directions)
{
    switch (direction)
    {
        case 'U':
            if (!Move(personPositionRow - 1, personPositionColumn))
            {
                PrintOutput();
                return;
            }
            break;
        case 'D':
            if (!Move(personPositionRow + 1, personPositionColumn))
            {
                PrintOutput();
                return;
            }
            break;
        case 'L':
            if (!Move(personPositionRow, personPositionColumn - 1))
            {
                PrintOutput();
                return;
            }
            break;
        case 'R':
            if (!Move(personPositionRow, personPositionColumn + 1))
            {
                PrintOutput();
                return;
            }
            break;
    }
}

bool Move(int targetRowIndex, int targetColumnIndex) // Indicates a successful move
{
    lair[personPositionRow, personPositionColumn] = '.';
    if (targetRowIndex < 0 || targetRowIndex >= lairRows || targetColumnIndex < 0 || targetColumnIndex >= lairColumns)
    {
        SpreadBunnies();
        return false;
    }

    SpreadBunnies();
    if (lair[targetRowIndex, targetColumnIndex] == 'B')
    {
        personPositionRow = targetRowIndex;
        personPositionColumn = targetColumnIndex;
        isDead = true;
        return false;
    }

    personPositionRow = targetRowIndex;
    personPositionColumn = targetColumnIndex;
    lair[personPositionRow, personPositionColumn] = 'P';
    return true;
}

void SpreadBunnies()
{
    bunniesCoordinates = new();
    for (int i = 0; i < lairRows; i++) for (int j = 0; j < lairColumns; j++) if (lair[i, j] == 'B') bunniesCoordinates.Add(new[] { i, j });

    foreach (int[] bunnyCoordinates in bunniesCoordinates)
    {
        int row = bunnyCoordinates[0];
        int column = bunnyCoordinates[1];

        // Set new bunnies where possible
        if (row + 1 < lairRows) lair[row + 1, column] = 'B';
        if (row - 1 >= 0) lair[row - 1, column] = 'B';
        if (column + 1 < lairColumns) lair[row, column + 1] = 'B';
        if (column - 1 >= 0) lair[row, column - 1] = 'B';
    }
}

void PrintOutput()
{
    for (int i = 0; i < lairRows; i++)
    {
        for (int j = 0; j < lairColumns; j++) Console.Write(lair[i, j]);
        Console.WriteLine();
    }

    Console.WriteLine(isDead
        ? $"dead: {personPositionRow} {personPositionColumn}"
        : $"won: {personPositionRow} {personPositionColumn}");
}