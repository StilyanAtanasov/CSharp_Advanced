Queue<string> customers = new();

string command = Console.ReadLine()!;
while (command != "End")
{
    if (command == "Paid")
    {
        Console.WriteLine(string.Join("\n", customers));
        customers.Clear();
    }
    else customers.Enqueue(command); // here command == customer name

    command = Console.ReadLine()!;
}

Console.WriteLine($"{customers.Count} people remaining.");