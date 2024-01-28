// ReSharper disable ConvertToLocalFunction
int minSum = int.Parse(Console.ReadLine()!);
string[] people = Console.ReadLine()!.Split();

Func<string, int, bool> getSum = (name, min) => name.Sum(c => c) >= min;
Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, min, checker) => names.First(x => checker(x, min));

Console.WriteLine(getFirstName(people, minSum, getSum));