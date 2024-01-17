uint[] matrixSize = Console.ReadLine()!.Split(", ").Select(uint.Parse).ToArray();
int[] sumByColumns = new int[matrixSize[1]];

for (int i = 0; i < matrixSize[0]; i++)
{
    int[] row = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
    for (int j = 0; j < matrixSize[1]; j++) sumByColumns[j] += row[j];
}

Console.WriteLine(string.Join("\n", sumByColumns));