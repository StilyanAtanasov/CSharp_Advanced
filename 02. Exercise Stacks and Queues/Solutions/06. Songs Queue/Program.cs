Queue<string> songs = new(Console.ReadLine()!.Split(", "));
while (songs.Count > 0)
{
    string[] command = Console.ReadLine()!.Split();
    switch (command[0]) // Real command. All next might be song names
    {
        case "Add":
            string song = String.Join(' ', command[1..]);
            if (!songs.Contains(song))songs.Enqueue(song);
            else Console.WriteLine($"{song} is already contained!");
            break;
        case "Show":
            Console.WriteLine(String.Join(", ", songs));
            break;
        case "Play":
            songs.Dequeue();
            break;
    }
}

Console.WriteLine("No more songs!");