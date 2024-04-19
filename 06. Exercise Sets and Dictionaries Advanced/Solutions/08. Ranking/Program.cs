Dictionary<string, string> courses = new(); // contestName, contestPass
Dictionary<string, Dictionary<string, uint>> candidates = new(); // candidateName, contest => points

string command;

// Read contests
while ((command = Console.ReadLine()!) != "end of contests")
{
    string[] cmdArgs = command.Split(':');
    string contestName = cmdArgs[0];
    string contestPass = cmdArgs[1];

    courses[contestName] = contestPass;
}

// Read submissions
while ((command = Console.ReadLine()!) != "end of submissions")
{
    string[] cmdArgs = command.Split("=>");
    string contestName = cmdArgs[0];
    string contestPass = cmdArgs[1];
    string username = cmdArgs[2];
    uint points = uint.Parse(cmdArgs[3]);

    if (courses.ContainsKey(contestName) && courses[contestName] == contestPass)
    {
        if (!candidates.ContainsKey(username)) candidates[username] = new();
        if (candidates[username].ContainsKey(contestName) && candidates[username][contestName] > points) continue;
        candidates[username][contestName] = points;
    }
}

// Sort the candidates by sum of their points to find the best candidate
candidates = candidates.OrderByDescending(c => c.Value.Sum(contest => contest.Value)).ToDictionary(k => k.Key, v => v.Value);
Console.WriteLine($"Best candidate is {candidates.First().Key} with total {candidates.First().Value.Sum(contest => contest.Value)} points.");

// Sort the candidates by names
candidates = candidates.OrderBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);

// Print the results of all the other candidates
Console.WriteLine("Ranking:");
foreach (var (candidateName, participations) in candidates)
{
    Console.WriteLine(candidateName);
    foreach (var (contestName, points) in participations.OrderByDescending(p => p.Value)) Console.WriteLine($"#  {contestName} -> {points}");
}