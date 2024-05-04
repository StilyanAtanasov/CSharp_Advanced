int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(FactorialCalculator(number));

int FactorialCalculator(int num)
{
    if (num == 1) return 1;
    return num * FactorialCalculator(num - 1);
}