Stack<char> stack = new(Console.ReadLine()!.ToCharArray());
while (stack.Count > 0) Console.Write(stack.Pop());