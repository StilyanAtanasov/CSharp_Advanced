byte bulletPrice = byte.Parse(Console.ReadLine()!);
ushort gunBarrelSize = ushort.Parse(Console.ReadLine()!);
Stack<byte> bullets = new(Console.ReadLine()!.Split().Select(byte.Parse));
Queue<byte> locks = new(Console.ReadLine()!.Split().Select(byte.Parse));
uint intelligenceValue = uint.Parse(Console.ReadLine()!);

ushort expenses = 0;
ushort shootsLeft = gunBarrelSize;
while (true)
{
    byte currentBullet = bullets.Pop();
    byte currentLock = locks.Peek();
    if (currentLock >= currentBullet)
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else Console.WriteLine("Ping!");

    shootsLeft--;
    expenses += bulletPrice;

    if (shootsLeft == 0 && bullets.Count > 0)
    {
        Console.WriteLine("Reloading!");
        shootsLeft = gunBarrelSize;
    }
    if (locks.Count == 0)
    {
        Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - expenses}");
        return;
    }
    if (bullets.Count == 0)
    {
        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        return;
    }
}