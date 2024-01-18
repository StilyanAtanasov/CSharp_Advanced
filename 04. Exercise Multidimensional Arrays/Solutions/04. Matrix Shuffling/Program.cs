ushort[] matrixSize = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(ushort.Parse).ToArray();
string[,] matrix = new string[matrixSize[0], matrixSize[1]];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    string[] row = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < matrix.GetLength(1); j++) matrix[i, j] = row[j];
}

string command = Console.ReadLine()!;
while (command != "END")
{
    string[] operation = command.Split();

    if (operation.Length != 5 || operation[0] != "swap")
    {
        Console.WriteLine("Invalid input!");
        command = Console.ReadLine()!;
        continue;
    }

    int index1 = int.Parse(operation[1]);
    int index2 = int.Parse(operation[2]);
    int index3 = int.Parse(operation[3]);
    int index4 = int.Parse(operation[4]);
    if (operation[1..].Count(x => int.Parse(x) >= 0) != operation[1..].Length || index1 >= matrixSize[0] || index3 >= matrixSize[0] || index2 >= matrixSize[1] || index4 >= matrixSize[1])
    {
        Console.WriteLine("Invalid input!");
        command = Console.ReadLine()!;
        continue;
    }

    (matrix[index1, index2], matrix[index3, index4]) = (matrix[index3, index4], matrix[index1, index2]);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }

    command = Console.ReadLine()!;
}