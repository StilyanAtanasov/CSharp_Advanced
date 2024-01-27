int[] integers = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();

Console.WriteLine(integers.Length);
Console.WriteLine(integers.Sum());