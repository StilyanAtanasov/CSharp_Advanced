ushort rows = ushort.Parse(Console.ReadLine()!);

int[][] jaggedArray = new int[rows][];
for (int i = 0; i < rows; i++) jaggedArray[i] = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

string command = Console.ReadLine()!;
while (command != "END")
{
    string[] operation = command.Split();

    int row = int.Parse(operation[1]);
    int column = int.Parse(operation[2]);
    int value = int.Parse(operation[3]);
    if (row >= jaggedArray.Length || row < 0 || column >= jaggedArray[row].Length || column < 0)
    {
        Console.WriteLine("Invalid coordinates");
        command = Console.ReadLine()!;
        continue;
    }

    switch (operation[0])
    {
        case "Add":
            jaggedArray[row][column] += value;
            break;
        case "Subtract":
            jaggedArray[row][column] -= value;
            break;
    }

    command = Console.ReadLine()!;
}

foreach (int[] array in jaggedArray) Console.WriteLine(string.Join(" ", array));