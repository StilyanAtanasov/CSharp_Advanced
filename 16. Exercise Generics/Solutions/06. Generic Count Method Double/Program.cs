using _06._Generic_Count_Method_Double;

Box<double> box = new();

ushort inputLinesCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < inputLinesCount; i++) box.List.Add(double.Parse(Console.ReadLine()!));

Console.WriteLine(Box<double>.ValidElementsCount(box.List, double.Parse(Console.ReadLine()!)));