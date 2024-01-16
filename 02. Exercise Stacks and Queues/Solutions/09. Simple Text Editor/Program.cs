Stack<string> textHistory = new();

ushort operationsCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < operationsCount; i++)
{
    string command = Console.ReadLine()!;
    if (textHistory.Count == 0)
    {
        if (command[0] == '1') textHistory.Push(command[2..]);
        continue;
    }

    string current = textHistory.Peek();
    switch (command[0])
    {    
        case '1':
            textHistory.Push(current + command[2..]);
            break;
        case '2':
            textHistory.Push(current[..^int.Parse(command[2..])]);
            break;
        case '3':
            Console.WriteLine(current[int.Parse(command[2..]) - 1]);
            break;
        case '4':
            textHistory.Pop();
            break;
    }
}