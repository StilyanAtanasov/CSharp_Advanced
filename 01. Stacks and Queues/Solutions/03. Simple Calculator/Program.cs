Stack<string> stack =  new(Console.ReadLine()!.Split().Reverse());
int result = Convert.ToInt32(stack.Pop());

while (stack.Count > 0)
{
    string token = stack.Pop();
    int number = Convert.ToInt32(stack.Pop());
    result = token == "+" ? result + number : result - number;
}

Console.WriteLine(result);