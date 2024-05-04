namespace SumOfCoins;

public class StartUp
{
    public static void Main(string[] args)
    {
        // Read the input
        int[] coins = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();
        int targetSum = int.Parse(Console.ReadLine()!);

        Dictionary<int, int> coinsChosen = ChooseCoins(coins, targetSum);

        // Print the output
        Console.WriteLine($"Number of coins to take: {coinsChosen.Sum(c => c.Value)}");
        foreach (var (coinValue, timesTaken) in coinsChosen.Where(c => c.Value != 0))
            Console.WriteLine($"{timesTaken} coin(s) with value {coinValue}");
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum) // output -> coinValue, timesTaken
    {
        Dictionary<int, int> coinsChosen = new();

        coins = coins.OrderByDescending(x => x).ToList();
        foreach (int coin in coins)
        {
            int timesUsed = 0;
            while (targetSum >= coin)
            {
                timesUsed++;
                targetSum -= coin;
            }

            if (timesUsed > 0) coinsChosen[coin] = timesUsed;
        }

        if (targetSum != 0) throw new InvalidOperationException();

        return coinsChosen;
    }
}