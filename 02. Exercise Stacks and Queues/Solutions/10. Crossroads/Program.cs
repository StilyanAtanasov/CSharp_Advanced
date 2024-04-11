byte greenLightDuration = byte.Parse(Console.ReadLine()!);
byte freeWindowDuration = byte.Parse(Console.ReadLine()!);

Queue<string> cars = new();

ushort passed = 0;

string input;
while ((input = Console.ReadLine()!) != "END")
{
    if (input != "green") cars.Enqueue(input);
    else // A car name
    {
        if (cars.Count == 0) continue;
        string current = cars.Peek();
        byte timeLeft = greenLightDuration;
        while (timeLeft > 0)
        {
            if (timeLeft >= current.Length)
            {
                timeLeft -= (byte)current.Length;
                cars.Dequeue();
                passed++;
                if (cars.Count == 0) break;
                current = cars.Peek();
            }
            else
            {
                current = current.Remove(0, timeLeft);
                if (current.Length > freeWindowDuration)
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{cars.Peek()} was hit at {current[freeWindowDuration]}.");
                    return;
                }

                cars.Dequeue();
                passed++;
                break;
            }
        }
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passed} total cars passed the crossroads.");