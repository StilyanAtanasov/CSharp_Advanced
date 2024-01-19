Dictionary<double, uint> numbers = new();

double[] inputNumbers = Console.ReadLine()!.Split().Select(double.Parse).ToArray();
foreach (double number in inputNumbers) numbers[number] = numbers.TryGetValue(number, out uint number1) ? number1 + 1 : 1;

foreach (var number in numbers) Console.WriteLine($"{number.Key} - {number.Value} times");