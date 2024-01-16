Stack<char> parentheses = new();

string inputParentheses = Console.ReadLine()!;
if (inputParentheses.Length % 2 == 1)
{
    Console.WriteLine("NO");
    return;
}

foreach (char c in inputParentheses)
{
    char currentChar = c;
    if (currentChar == '(' || currentChar == '[' || currentChar == '{') parentheses.Push(currentChar);
    else
    {
        char correctChar = '\0';
        switch (parentheses.Peek())
        {
            case '(': correctChar = ')'; break;
            case '[': correctChar = ']'; break;
            case '{': correctChar = '}'; break;
        }

        if (c == correctChar) parentheses.Pop();
    }
}

Console.WriteLine(parentheses.Count == 0 ? "YES" : "NO");