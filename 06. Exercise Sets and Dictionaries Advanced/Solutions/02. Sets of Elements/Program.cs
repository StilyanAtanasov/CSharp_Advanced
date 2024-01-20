byte[] sizes = Console.ReadLine()!.Split().Select(byte.Parse).ToArray();
byte n = sizes[0]; // First HashSet Length
byte m = sizes[1]; // Second HashSet Length

HashSet<decimal> setN = new();
HashSet<decimal> setM = new();

for (int i = 0; i < n; i++) setN.Add(decimal.Parse(Console.ReadLine()!));
for (int i = 0; i < m; i++) setM.Add(decimal.Parse(Console.ReadLine()!));

setN.IntersectWith(setM);
Console.WriteLine(string.Join(" ", setN));