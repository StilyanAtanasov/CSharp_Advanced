Queue<int[]> pumps = new();

int pumpsCount = int.Parse(Console.ReadLine()!);
for (int i = 0; i < pumpsCount; i++) pumps.Enqueue(Console.ReadLine()!.Split().Select(int.Parse).ToArray());

int fuel = 0;
int index = 0;
int currentIndex = 0;
foreach (int[] pump in pumps)
{
    fuel += pump[0];
    if (fuel >= pump[1]) fuel -= pump[1];
    else
    {
        fuel = 0;
        index = currentIndex + 1;
    }

    currentIndex++;
}

Console.WriteLine(index);