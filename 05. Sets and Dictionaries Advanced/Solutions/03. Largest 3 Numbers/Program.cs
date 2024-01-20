List<int> integers = Console.ReadLine()!.Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
 Console.Write(string.Join(" ", integers));