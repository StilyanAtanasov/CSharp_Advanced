// Read the input
Stack<byte> pocket = new(Console.ReadLine()!.Split().Select(byte.Parse));
Queue<byte> prices = new(Console.ReadLine()!.Split().Select(byte.Parse));

// Implement buying
byte foodBought = 0;
while (true)
{
    byte money = pocket.Peek();
    byte price = prices.Peek();
    if (money < price)
    {
        pocket.Pop();
        prices.Dequeue();
        if (prices.Count == 0 || pocket.Count == 0) break;
        continue;
    }

    byte moneyDifference = (byte)(money - price);
    pocket.Pop();
    if (pocket.Count > 0) pocket.Push((byte)(pocket.Pop() + moneyDifference));
    prices.Dequeue();
    foodBought++;

    if (prices.Count == 0 || pocket.Count == 0) break;
}

// Print the output
if (foodBought >= 4) Console.WriteLine($"Gluttony of the day! Henry ate {foodBought} foods.");
else
{
    if (foodBought > 1) Console.WriteLine($"Henry ate: {foodBought} foods.");
    else if (foodBought == 1) Console.WriteLine($"Henry ate: {foodBought} food.");
    else Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}