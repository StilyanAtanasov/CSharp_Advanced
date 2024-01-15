Stack<byte> box = new(Console.ReadLine()!.Split().Select(byte.Parse));
byte rackCapacity = byte.Parse(Console.ReadLine()!);

byte racksUsed = 1;
byte currentCapacity = 0;
while (box.Count > 0)
{
    if (currentCapacity + box.Peek() <= rackCapacity) currentCapacity += box.Pop();
    else
    {
        racksUsed++;
        currentCapacity = box.Pop();
    }
}

Console.WriteLine(racksUsed);