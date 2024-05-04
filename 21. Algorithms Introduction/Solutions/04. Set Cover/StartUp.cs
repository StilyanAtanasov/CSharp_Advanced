namespace SetCover;

class StartUp
{
    static void Main(string[] args)
    {
        // Read the input
        int[] universe = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();
        int setsCount = int.Parse(Console.ReadLine()!);
        List<int[]> sets = new();
        for (int i = 0; i < setsCount; i++) sets.Add(Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray());

        List<int[]> setsChosen = ChooseSets(sets, universe);

        // Print the output
        Console.WriteLine($"Sets to take ({setsChosen.Count}):");
        foreach (int[] set in setsChosen) Console.WriteLine($"{{ {string.Join(", ", set)} }}");
    }

    public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
    {
        List<int[]> setsChosen = new();
        List<int> universeNumbersLeft = universe.ToList();


        while (universeNumbersLeft.Count > 0)
        {
            int[] bestSet = sets.OrderByDescending(s => s.Count(universeNumbersLeft.Contains)).First();
            foreach (int element in bestSet) universeNumbersLeft.Remove(element);

            setsChosen.Add(bestSet);
            sets.Remove(bestSet);
        }

        return setsChosen;
    }
}