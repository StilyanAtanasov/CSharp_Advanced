Queue<int> numbers = new(Console.ReadLine()!.Split().Select(int.Parse));

uint numbersCount = (uint) numbers.Count;
for (int i = 0; i < numbersCount; i++)
{
    int number = numbers.Dequeue();
    if (number % 2 == 0) numbers.Enqueue(number);
}

Console.WriteLine(string.Join(", ", numbers));