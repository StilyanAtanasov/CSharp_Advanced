// Read the input
Queue<uint> tools = new(Console.ReadLine()!.Split().Select(uint.Parse));
Stack<uint> substances = new(Console.ReadLine()!.Split().Select(uint.Parse));
List<uint> challenges = Console.ReadLine()!.Split().Select(uint.Parse).ToList();

while (true)
{
    uint result = tools.Peek() * substances.Peek();
    if (challenges.Contains(result))
    {
        tools.Dequeue();
        substances.Pop();
        challenges.RemoveAt(challenges.IndexOf(result));
    }
    else
    {
        tools.Enqueue(tools.Dequeue() + 1);
        substances.Push(substances.Pop() - 1);
        if (substances.Peek() == 0) substances.Pop();
    }

    if ((tools.Count == 0 || substances.Count == 0) && challenges.Count > 0)
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }

    if (challenges.Count == 0)
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        break;
    }
}

// Print the output
if (tools.Count > 0) Console.WriteLine($"Tools: {string.Join(", ", tools)}");
if (substances.Count > 0) Console.WriteLine($"Substances: {string.Join(", ", substances)}");
if (challenges.Count > 0) Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");