using _04._Froggy;

int[] stones = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();

Lake lake = new(stones);
Console.WriteLine(string.Join(", ", lake));