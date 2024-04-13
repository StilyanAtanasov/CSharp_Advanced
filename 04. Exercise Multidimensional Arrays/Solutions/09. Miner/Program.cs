uint fieldSize = uint.Parse(Console.ReadLine()!);
string[] directions = Console.ReadLine()!.Split();

int minerPositionRow = Int32.MinValue;
int minerPositionColumn = Int32.MinValue;

uint coalCount = 0;
uint coalFound = 0;

char[,] field = new char[fieldSize, fieldSize];
for (int i = 0; i < fieldSize; i++)
{
    char[] row = Console.ReadLine()!.Split().Select(char.Parse).ToArray();
    for (int j = 0; j < fieldSize; j++)
    {
        field[i, j] = row[j];
        if (field[i, j] == 's')
        {
            minerPositionRow = i;
            minerPositionColumn = j;
        }
        if (field[i, j] == 'c') coalCount++;
    }
}

foreach (string direction in directions)
{
    switch (direction)
    {
        case "up":
            if (!Move(minerPositionRow - 1, minerPositionColumn)) return; // In case it returns false => the move was special
            break;
        case "down":
            if (!Move(minerPositionRow + 1, minerPositionColumn)) return;
            break;
        case "left":
            if (!Move(minerPositionRow, minerPositionColumn - 1)) return;
            break;
        case "right":
            if (!Move(minerPositionRow, minerPositionColumn + 1)) return;
            break;
    }
}

bool Move(int targetPositionRow, int targetPositionColumn)
{
    // Check if indexes are out of field - then do nothing
    if (targetPositionRow < 0 || targetPositionRow >= fieldSize || targetPositionColumn < 0 || targetPositionColumn >= fieldSize) return true;

    field[minerPositionRow, minerPositionColumn] = '*';

    // Check if the next position is a special symbol
    if (field[targetPositionRow, targetPositionColumn] == 'e') // Indicates the "end"
    {
        Console.WriteLine($"Game over! ({targetPositionRow}, {targetPositionColumn})");
        return false;
    }
    if (field[targetPositionRow, targetPositionColumn] == 'c')
    {
        coalFound++;
        if (coalFound == coalCount)
        {
            Console.WriteLine($"You collected all coals! ({targetPositionRow}, {targetPositionColumn})");
            return false;
        }
    }

    minerPositionRow = targetPositionRow;
    minerPositionColumn = targetPositionColumn;
    field[minerPositionRow, minerPositionColumn] = 's';
    return true;
}

Console.WriteLine($"{coalCount - coalFound} coals left. ({minerPositionRow}, {minerPositionColumn})"); // if we run out of directions