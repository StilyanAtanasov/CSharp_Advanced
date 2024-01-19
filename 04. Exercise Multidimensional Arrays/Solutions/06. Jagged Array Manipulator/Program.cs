ushort rows = ushort.Parse(Console.ReadLine()!);
decimal[][] jaggedArray = new decimal[rows][];

for (int i = 0; i < rows; i++) jaggedArray[i] = Console.ReadLine()!.Split().Select(decimal.Parse).ToArray();

for (int i = 0; i < rows - 1; i++)
{
    if (jaggedArray[i].Length != jaggedArray[i + 1].Length) for (int k = 0; k < 2; k++) for (int j = 0; j < jaggedArray[i + k].Length; j++) jaggedArray[i + k][j] /= 2;
    else for (int k = 0; k < 2; k++) for (int j = 0; j < jaggedArray[i + k].Length; j++) jaggedArray[i + k][j] *= 2;
}

string command = Console.ReadLine()!;
while (command != "End")
{
    string[] operation = command.Split();
    int rowIndex = int.Parse(operation[1]);
    int columnIndex = int.Parse(operation[2]);
    int value = int.Parse(operation[3]);

    if (rowIndex < rows && rowIndex >= 0 && columnIndex >= 0 && columnIndex < jaggedArray[rowIndex].Length)
        switch (operation[0])
        {
            case "Add": jaggedArray[rowIndex][columnIndex] += value; break;
            case "Subtract": jaggedArray[rowIndex][columnIndex] -= value; break;
        }

    command = Console.ReadLine()!;
}

foreach (decimal[] array in jaggedArray) Console.WriteLine(string.Join(" ", array));