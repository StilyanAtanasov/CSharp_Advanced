Stack<int> stack = new(Console.ReadLine()!.Split().Select(int.Parse));
string input = Console.ReadLine()!.ToLower();

while (input != "end")
{
    string[] command = input.Split();
    switch (command[0])
    {
        case "add":
            stack.Push(int.Parse(command[1])); // command[1] == element No1 to add
            stack.Push(int.Parse(command[2])); // command[2] == element No2 to add
            break;
        case "remove":
            if (int.Parse(command[1]) <= stack.Count) for (int i = 0; i < int.Parse(command[1]); i++) stack.Pop(); // command[1] == elements to remove
            break;
    }
    input = Console.ReadLine()!.ToLower();
}

Console.WriteLine("Sum: " + stack.Sum());