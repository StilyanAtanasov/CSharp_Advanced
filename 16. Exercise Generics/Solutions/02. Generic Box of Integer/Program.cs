using _02._Generic_Box_of_Integer;

List<Box<int>> list = new();

ushort inputLinesCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputLinesCount; i++) list.Add(new Box<int>(int.Parse(Console.ReadLine()!)));

foreach (Box<int> box in list) Console.WriteLine(box.ToString());