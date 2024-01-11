Queue<string> children = new(Console.ReadLine()!.Split());
int passes = int.Parse(Console.ReadLine()!);

while (children.Count > 1)
{
    for (int i = 0; i < passes - 1; i++) children.Enqueue(children.Dequeue());
    Console.WriteLine($"Removed {children.Dequeue()}");
}

Console.WriteLine($"Last is {children.Dequeue()}");