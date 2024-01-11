Stack<ushort> brackets = new();

string expression = Console.ReadLine()!;

for (ushort i = 0; i < expression.Length; i++)
{
    switch (expression[i])
    {
        case '(':
            brackets.Push(i);
            break;
        case ')':
            Console.WriteLine(expression[brackets.Pop()..(i + 1)]);
            break;

    }
}