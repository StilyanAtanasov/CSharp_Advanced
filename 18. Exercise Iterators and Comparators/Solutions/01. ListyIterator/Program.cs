using _01._ListyIterator;

string command = Console.ReadLine()!;
ListyIterator<string> iterator = new(command.Split()[1..]); // Format: Create E1 E2 ...

while ((command = Console.ReadLine()!) != "END")
{
    switch (command)
    {
        case "HasNext": Console.WriteLine(iterator.HasNext()); break;
        case "Move": Console.WriteLine(iterator.Move()); break;
        case "Print": iterator.Print(); break;
    }
}