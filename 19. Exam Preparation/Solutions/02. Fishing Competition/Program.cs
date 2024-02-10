int fishingAreaSize = int.Parse(Console.ReadLine()!);

int boatRow = 0;
int boatColumn = 0;

char[,] fishingArea = new char[fishingAreaSize, fishingAreaSize];
for (int i = 0; i < fishingAreaSize; i++)
{
    char[] row = Console.ReadLine()!.ToCharArray();
    for (int j = 0; j < fishingAreaSize; j++)
    {
        fishingArea[i, j] = row[j];
        if (fishingArea[i, j] == 'S')
        {
            boatRow = i;
            boatColumn = j;
        }
    }
}

int tonsOfFishFound = 0;

string command;
while ((command = Console.ReadLine()!) != "collect the nets")
{
    // Move boat and save what found
    char found = '\0';
    switch (command)
    {
        case "up":
            fishingArea[boatRow, boatColumn] = '-';
            boatRow = CheckOverflow(boatRow - 1, 0, fishingAreaSize - 1);
            found = fishingArea[boatRow, boatColumn];
            fishingArea[boatRow, boatColumn] = 'S';
            break;
        case "down":
            fishingArea[boatRow, boatColumn] = '-';
            boatRow = CheckOverflow(boatRow + 1, 0, fishingAreaSize - 1);
            found = fishingArea[boatRow, boatColumn];
            fishingArea[boatRow, boatColumn] = 'S';
            break;
        case "left":
            fishingArea[boatRow, boatColumn] = '-';
            boatColumn = CheckOverflow(boatColumn - 1, 0, fishingAreaSize - 1);
            found = fishingArea[boatRow, boatColumn];
            fishingArea[boatRow, boatColumn] = 'S';
            break;
        case "right":
            fishingArea[boatRow, boatColumn] = '-';
            boatColumn = CheckOverflow(boatColumn + 1, 0, fishingAreaSize - 1);
            found = fishingArea[boatRow, boatColumn];
            fishingArea[boatRow, boatColumn] = 'S';
            break;
    }

    // Check what found
    if (found == 'W')
    {
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{boatRow},{boatColumn}]");
        return;
    }
    if (found != '-') tonsOfFishFound += (int) char.GetNumericValue(found); // then it is number => fish passage
}

// Print result
Console.WriteLine(tonsOfFishFound >= 20
    ? "Success! You managed to reach the quota!"
    : $"You didn't catch enough fish and didn't reach the quota! You need {20 - tonsOfFishFound} tons of fish more."); // The min amount to complete the task is 20 tons
if (tonsOfFishFound > 0) Console.WriteLine($"Amount of fish caught: {tonsOfFishFound} tons.");

// Print the fishing area
for (int i = 0; i < fishingAreaSize; i++)
{
    for (int j = 0; j < fishingAreaSize; j++) Console.Write(fishingArea[i, j]);
    Console.WriteLine();
}

static int CheckOverflow(int position, int constraint1, int constraint2)
{
    if (position >= constraint1 && position <= constraint2) return position;
    if (position < constraint1) return constraint2;
    return constraint1;
}