// Read the dimensions of the cupboard
int[] cupboardDimensions = Console.ReadLine()!.Split(',').Select(int.Parse).ToArray();
int rows = cupboardDimensions[0];
int columns = cupboardDimensions[1];

// Initialise and read the cupboard (matrix), find and set the mouse initial position
char[,] cupboard = new char[rows, columns];
int mouseRow = 0;
int mouseColumn = 0;

for (int i = 0; i < rows; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (int j = 0; j < columns; j++)
    {
        if ((cupboard[i, j] = row[j]) == 'M')
        {
            mouseRow = i;
            mouseColumn = j;
        }
    }
}

// Implement the movements
string command;
while ((command = Console.ReadLine()!) != "danger")
{
    if (command == "up")
    {
        if (CanMove(mouseRow - 1, rows - 1, 0)) // @ means wall
        {
            if (cupboard[mouseRow - 1, mouseColumn] != '@')
            {
                if (!CheckForTrap(mouseRow - 1, mouseColumn)) return;
                cupboard[mouseRow, mouseColumn] = '*';
                cupboard[mouseRow -= 1, mouseColumn] = 'M';
            }
        }
        else return;

        if (!CheckForCheese()) return;
    }
    else if (command == "down")
    {
        if (CanMove(mouseRow + 1, rows - 1, 0)) // @ means wall
        {
            if (cupboard[mouseRow + 1, mouseColumn] != '@')
            {
                if (!CheckForTrap(mouseRow + 1, mouseColumn)) return;
                cupboard[mouseRow, mouseColumn] = '*';
                cupboard[mouseRow += 1, mouseColumn] = 'M';
            }
        }
        else return;

        if (!CheckForCheese()) return;
    }
    else if (command == "right")
    {
        if (CanMove(mouseColumn + 1, columns - 1, 0)) // @ means wall
        {
            if (cupboard[mouseRow, mouseColumn + 1] != '@')
            {
                if (!CheckForTrap(mouseRow, mouseColumn + 1)) return;
                cupboard[mouseRow, mouseColumn] = '*';
                cupboard[mouseRow, mouseColumn += 1] = 'M';
            }
        }
        else return;

        if (!CheckForCheese()) return;
    }
    else // left
    {
        if (CanMove(mouseColumn - 1, columns - 1, 0))
        {
            if (cupboard[mouseRow, mouseColumn - 1] != '@')
            {
                if (!CheckForTrap(mouseRow, mouseColumn - 1)) return;
                cupboard[mouseRow, mouseColumn] = '*';
                cupboard[mouseRow, mouseColumn -= 1] = 'M';
            }
        }
        else return;

        if (!CheckForCheese()) return;
    }
}

// Print the final result
Console.WriteLine("Mouse will come back later!");
PrintMatrix();

bool CanMove(int nextPosition, int maxBorder, int minBorder)
{
    if (nextPosition < minBorder || nextPosition > maxBorder)
    {
        Console.WriteLine("No more cheese for tonight!"); // The mouse has left the cupboard
        PrintMatrix();
        return false;
    }

    return true;
}

bool CheckForTrap(int row, int column)
{
    if (cupboard[row, column] == 'T') // T stands for trap
    {
        Console.WriteLine("Mouse is trapped!");
        cupboard[mouseRow, mouseColumn] = '*';
        cupboard[row, column] = 'M';
        PrintMatrix();
        return false;
    }

    return true;
}

bool CheckForCheese()
{
    foreach (char c in cupboard) if (c == 'C') return true; // C equals Cheese

    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
    PrintMatrix();
    return false;
}

void PrintMatrix()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) Console.Write(cupboard[i, j]);
        Console.WriteLine();
    }
}