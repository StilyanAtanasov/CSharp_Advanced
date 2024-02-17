// Initialize the field
byte airfieldSize = byte.Parse(Console.ReadLine()!); // will be in range 4..10
char[,] airfield = new char[airfieldSize, airfieldSize];

// Jetfighter coordinates
byte jetfigterRow = 0;
byte jetfigterColumn = 0;

// Enemy ships count
byte enemyShips = 0;

// Our ship health
ushort health = 300;

// Read the field
for (byte i = 0; i < airfieldSize; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (byte j = 0; j < airfieldSize; j++)
    {
        airfield[i, j] = row[j];
        if (row[j] == 'J') // 'J' stands for our initial position of the jetfighter
        {
            jetfigterRow = i;
            jetfigterColumn = j;
        }
        else if (row[j] == 'E') enemyShips++; // 'E' stands for enemy ship
    }
}

// Implement the actions
while (true)
{
    string direction = Console.ReadLine()!; // Always the direction will lead to an existing position in the matrix
    switch (direction)
    {
        case "up":
            if (!HandleMove((byte)(jetfigterRow - 1), jetfigterColumn)) return;
            break;
        case "down":
            if (!HandleMove((byte)(jetfigterRow + 1), jetfigterColumn)) return;
            break;
        case "left":
            if (!HandleMove(jetfigterRow, (byte)(jetfigterColumn - 1))) return;
            break;
        case "right":
            if (!HandleMove(jetfigterRow, (byte)(jetfigterColumn + 1))) return;
            break;
    }
}

bool HandleMove(byte nextPositionY, byte nextPositionX) // Returns whether the plane should continue 
{
    if (airfield[nextPositionY, nextPositionX] == 'R') health = 300; // 'R' stands for a Repair station
    else if (airfield[nextPositionY, nextPositionX] == 'E')
    {
        health -= 100;
        enemyShips--;
    }

    // Set the new coordinates
    airfield[jetfigterRow, jetfigterColumn] = '-';
    airfield[nextPositionY, nextPositionX] = 'J';
    jetfigterRow = nextPositionY;
    jetfigterColumn = nextPositionX;

    if (health == 0)
    {
        Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetfigterRow}, {jetfigterColumn}]!");
        PrintAirfield();
        return false;
    }
    else if (enemyShips == 0)
    {
        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
        PrintAirfield();
        return false;
    }

    return true;
}

void PrintAirfield()
{
    for (int i = 0; i < airfieldSize; i++)
    {
        for (int j = 0; j < airfieldSize; j++) Console.Write(airfield[i, j]);
        Console.WriteLine();
    }
}