using _01._Generic_Box_of_String;

List<Box<string>> list = new();

ushort inputLinesCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputLinesCount; i++) list.Add(new Box<string>(Console.ReadLine()!));

foreach (Box<string> box in list) Console.WriteLine(box.ToString());