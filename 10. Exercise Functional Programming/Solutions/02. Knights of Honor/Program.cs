// ReSharper disable ConvertToLocalFunction
Action<string> print = s => Console.WriteLine($"Sir {s}");
Console.ReadLine()!.Split().ToList().ForEach(print);