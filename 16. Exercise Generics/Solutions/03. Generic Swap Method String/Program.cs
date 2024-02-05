List<string> list = new();

ushort inputLinesCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputLinesCount; i++) list.Add(Console.ReadLine()!);

int[] indexes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
int index1 = indexes[0];
int index2 = indexes[1];

foreach (string s in Swapper(list, index1, index2)) Console.WriteLine($"{s.GetType()}: {s}");

static List<T> Swapper<T>(List<T> list, int index1, int index2)
{
     (list[index1], list[index2]) = (list[index2], list[index1]);
     return list;
}