Stack<int> initialFuel = new(Console.ReadLine()!.Split().Select(int.Parse));
Queue<int> consumption  = new(Console.ReadLine()!.Split().Select(int.Parse));
Queue<int> fuelNeeded = new(Console.ReadLine()!.Split().Select(int.Parse));

List<string> reachedAltitudes = new();
while (initialFuel.Peek() - consumption.Peek() >= fuelNeeded.Peek())
{
    initialFuel.Pop();
    consumption.Dequeue();
    fuelNeeded.Dequeue();

    int altitudeIndex = 4 - initialFuel.Count; // Always there will be 4 altitudes
    Console.WriteLine($"John has reached: Altitude {altitudeIndex}");
    reachedAltitudes.Add($"Altitude {altitudeIndex}");
}

if (initialFuel.Count != 0)
{
    Console.WriteLine($"John did not reach: Altitude {4 - initialFuel.Count + 1}");
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine(initialFuel.Count != 4 ? $"Reached altitudes: {string.Join(", ", reachedAltitudes)}" : "John didn't reach any altitude.");
}
else Console.WriteLine("John has reached all the altitudes and managed to reach the top!");