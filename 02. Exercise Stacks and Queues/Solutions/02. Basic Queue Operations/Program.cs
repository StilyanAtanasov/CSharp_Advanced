int[] values = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int n = values[0]; // Stack length
int s = values[1]; // Elements to remove
int x = values[2]; // Element to find

Queue<int> queue = new(Console.ReadLine()!.Split().Select(int.Parse).ToArray()[..n]);

if (s > n) s = n;
for (int i = 0; i < s; i++) queue.Dequeue();

if (queue.Count == 0) Console.WriteLine(0);
else if (queue.Contains(x)) Console.WriteLine("true");
else Console.WriteLine(queue.Min());