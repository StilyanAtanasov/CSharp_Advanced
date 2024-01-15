ushort foodAvailable = ushort.Parse(Console.ReadLine()!);

Queue<ushort> orders = new(Console.ReadLine()!.Split().Select(ushort.Parse));
Console.WriteLine(orders.Max());
while (orders.Count > 0)
{
    ushort order = orders.Peek();
    if (order <= foodAvailable)
    {
        foodAvailable -= order;
        orders.Dequeue();
    }
    else
    {
       Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
       return;
    }
}

Console.WriteLine("Orders complete");