using _05._Generic_Count_Method_String;

Box<string> box = new();

ushort inputLinesCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputLinesCount; i++) box.List.Add(Console.ReadLine()!);

Console.WriteLine(Box<string>.ValidElementsCount(box.List, Console.ReadLine()!));