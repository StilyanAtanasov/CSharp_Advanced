ushort size = ushort.Parse(Console.ReadLine()!);

ulong[][] pascalTriangle = new ulong[size][];
pascalTriangle[0] = new ulong[] { 1 };
for (int i = 1; i < size; i++)
{
    pascalTriangle[i] = new ulong[i + 1];
    pascalTriangle[i][0] = 1;
    pascalTriangle[i][^1] = 1;
    for (int j = 1; j < pascalTriangle[i].Length - 1; j++) pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
}

foreach (ulong[] row in pascalTriangle) Console.WriteLine(string.Join(" ", row));