int[] values = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int n = values[0]; // Stack length
int s = values[1]; // Elements to Pop()
int x = values[2]; // Element to find

Stack<int> stack = new(Console.ReadLine()!.Split().Select(int.Parse).ToArray()[..n]);

if (s > n) s = n;
for (int i = 0; i < s; i++) stack.Pop();

if (stack.Count == 0) Console.WriteLine(0);
else if (stack.Contains(x)) Console.WriteLine("true");
else Console.WriteLine(stack.Min());