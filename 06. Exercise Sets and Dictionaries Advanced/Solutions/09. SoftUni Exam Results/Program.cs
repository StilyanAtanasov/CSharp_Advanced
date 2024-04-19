Dictionary<string, byte> contestants = new(); // contestantName, maxPoints
Dictionary<string, ushort> submissionsInfo = new(); // language, number of submissions

string command;
while ((command = Console.ReadLine()!) != "exam finished")
{
    if (command.Contains("banned"))
    {
        contestants.Remove(command.Split('-')[0]);
        continue;
    }

    string[] cmdArgs = command.Split('-');
    string contestantName = cmdArgs[0];
    string language = cmdArgs[1];
    byte points = byte.Parse(cmdArgs[2]);

    // Handle submission
    submissionsInfo.TryAdd(language, new());
    submissionsInfo[language]++;

    // Handle contestant
    contestants.TryAdd(contestantName, new());
    if (contestants[contestantName] > points) continue;
    contestants[contestantName] = points;
}

// Sort repositories
contestants = contestants.OrderByDescending(c => c.Value).ThenBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);
submissionsInfo = submissionsInfo.OrderByDescending(s => s.Value).ThenBy(s => s.Key).ToDictionary(k => k.Key, v => v.Value);

// Print output
Console.WriteLine("Results:");
foreach (var contestant in contestants) Console.WriteLine($"{contestant.Key} | {contestant.Value}");

Console.WriteLine("Submissions:");
foreach (var submission in submissionsInfo) Console.WriteLine($"{submission.Key} - {submission.Value}");