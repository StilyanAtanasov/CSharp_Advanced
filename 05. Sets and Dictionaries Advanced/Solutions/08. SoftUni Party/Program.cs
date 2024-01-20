HashSet<string> guestNotCame = new();

bool partyStarted = false;
string command = Console.ReadLine()!;
while (command != "END")
{
    if (command == "PARTY") partyStarted = true;
    else
    {
        if (partyStarted == false) guestNotCame.Add(command); // command == guestNumber
        else guestNotCame.Remove(command); // command == guestNumber
    }

    command = Console.ReadLine()!;
}

Console.WriteLine(guestNotCame.Count);
Console.WriteLine(string.Join("\n", guestNotCame.OrderByDescending(x => int.TryParse(Convert.ToString(x[0]), out _ ))));