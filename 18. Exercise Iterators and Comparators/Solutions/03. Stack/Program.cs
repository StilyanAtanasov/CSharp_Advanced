_03._Stack.Stack<int> stack = new();

string command;
while ((command = Console.ReadLine()!) != "END") // the command, then, is Push E1, E2 ... or Pop
{
    if (command == "Pop")
    {
        try
        {
            stack.Pop();
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("No elements");
        }
    }
    else foreach (string element in command.Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)[1..]) stack.Push(int.Parse(element));
}

foreach (int element in stack) Console.WriteLine(element);
foreach (int element in stack) Console.WriteLine(element);