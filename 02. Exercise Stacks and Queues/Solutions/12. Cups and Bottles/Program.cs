Queue<ushort> cups = new(Console.ReadLine()!.Split().Select(ushort.Parse));
Stack<ushort> bottles = new(Console.ReadLine()!.Split().Select(ushort.Parse));

ushort wastedWater = 0;
int currentCupCapacity = cups.Peek();
while (true)
{
    ushort currentBottle = bottles.Pop();
    currentCupCapacity -= currentBottle;
    if (currentCupCapacity <= 0)
    {
        wastedWater -= (ushort)currentCupCapacity;
        cups.Dequeue();
        if (cups.Count != 0) currentCupCapacity = cups.Peek();
    }

    if (cups.Count == 0 || bottles.Count == 0)
    {
        Console.WriteLine($"{(cups.Count == 0 ? "Bottles" : "Cups")}: {(bottles.Count == 0 ? string.Join(' ', cups) : string.Join(' ', bottles))}");
        Console.WriteLine($"Wasted litters of water: {wastedWater}");
        return;
    }
}