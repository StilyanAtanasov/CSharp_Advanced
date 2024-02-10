using _02._Collection;

string command = Console.ReadLine()!;
ListyIterator<string> iterator = new(command.Split()[1..]); // Format: Create E1 E2 ...

while ((command = Console.ReadLine()!) != "END")
{
    switch (command)
    {
        case "HasNext": Console.WriteLine(iterator.HasNext()); break;
        case "Move": Console.WriteLine(iterator.Move()); break;
        case "Print": iterator.Print(); break;
        case "PrintAll": 
            foreach (string element in iterator) Console.Write($"{element} ");
            Console.WriteLine();
            break;
    }
}