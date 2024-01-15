Stack<int> stack = new();

byte commandsCount = byte.Parse(Console.ReadLine()!);
for (int i = 0; i < commandsCount; i++)
{
    string[] command = Console.ReadLine()!.Split();
    switch (command[0])
    {
        case "1":
            stack.Push(int.Parse(command[1]));
            break;
        case "2":
            stack.Pop();
            break;
        case "3":
            if (stack.Count > 0) Console.WriteLine(stack.Max());
            break;
        case "4":
            if (stack.Count > 0) Console.WriteLine(stack.Min());
            break;
    }
}

Console.WriteLine(string.Join(", ", stack));