short maxLength = short.Parse(Console.ReadLine()!);

// ReSharper disable once ConvertToLocalFunction
Predicate<string> isValid = s => s.Length <= maxLength;
Console.ReadLine()!.Split().Where(s => isValid(s)).ToList().ForEach(Console.WriteLine);