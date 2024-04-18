Dictionary<string, List<string>> vloggers = new(); // vloggerName, following

string command;
while ((command = Console.ReadLine()!) != "Statistics")
{
    string[] cmdArgs = command.Split();
    string cmdModifier = cmdArgs[1];
    switch (cmdModifier)
    {
        case "joined":
            string vlogger = cmdArgs[0];
            if (!vloggers.ContainsKey(vlogger)) vloggers[vlogger] = new();
            break;
        case "followed":
            string follower = cmdArgs[0];
            string following = cmdArgs[2];
            if (vloggers.ContainsKey(following) && vloggers.ContainsKey(follower) && following != follower && !vloggers[follower].Contains(following))
                vloggers[follower].Add(following);
            break;
    }
}

// Print total vloggers count
Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

// Sort the database
vloggers = vloggers.OrderByDescending(v => vloggers.Count(f => f.Value.Contains(v.Key)))
                   .ThenBy(v => v.Value.Count).ToDictionary(k => k.Key, v => v.Value);

// Get and print the info for the most famous vlogger
var mostFamousVlogger = vloggers.First();
Console.WriteLine($"1. {mostFamousVlogger.Key} : {vloggers.Count(f => f.Value.Contains(mostFamousVlogger.Key))} followers, {mostFamousVlogger.Value.Count} following");
foreach (var follower in vloggers.Where(f => f.Value.Contains(mostFamousVlogger.Key)).OrderBy(f => f.Key))
    Console.WriteLine($"*  {follower.Key}");

// Print all the other vloggers info
ushort counter = 2;
foreach (var (name, following) in vloggers.Take(1..))
{
    Console.WriteLine($"{counter}. {name} : {vloggers.Count(f => f.Value.Contains(name))} followers, {following.Count} following");
    counter++;
}