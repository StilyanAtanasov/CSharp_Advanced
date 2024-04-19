Dictionary<string, List<string>> forceUsers = new(); // side, forceUsers

string command;
while ((command = Console.ReadLine()!) != "Lumpawaroo")
{
    if (command.Contains(" | "))
    {
        string[] cmdArgs = command.Split(" | ");
        string side = cmdArgs[0];
        string user = cmdArgs[1];

        HandleSide(side);
        if (!forceUsers.Any(f => f.Value.Contains(user))) forceUsers[side].Add(user);
    }
    else // The command contains " -> "
    {
        string[] cmdArgs = command.Split(" -> ");
        string user = cmdArgs[0];
        string side = cmdArgs[1];

        HandleSide(side);

        string? forceSide = forceUsers.FirstOrDefault(f => f.Value.Contains(user)).Key;
        if (forceSide != null) forceUsers[forceSide].Remove(user);

        forceUsers[side].Add(user);

        Console.WriteLine($"{user} joins the {side} side!");
    }
}

foreach (var (forceSide, users) in forceUsers.Where(f => f.Value.Count != 0).OrderByDescending(f => f.Value.Count).ThenBy(f => f.Key))
{
    Console.WriteLine($"Side: {forceSide}, Members: {users.Count}");
    foreach (string forceUser in users.OrderBy(u => u)) Console.WriteLine($"! {forceUser}");
}

void HandleSide(string side)
{
    if (!forceUsers.ContainsKey(side)) forceUsers[side] = new();
}