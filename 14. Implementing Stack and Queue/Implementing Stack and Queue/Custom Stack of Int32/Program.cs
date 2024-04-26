using Custom_Stack_of_Int32;

// Sample Code Usage

CustomStackOfInt32 stack = new();

// Push some elements
PushTenElements();
Console.WriteLine("Peek after pushing 10 elements: " + stack.Peek()); // Expected output: 10

// Pop some elements
Console.WriteLine("Pop: " + stack.Pop()); // Expected output: 10
Console.WriteLine("Pop: " + stack.Pop()); // Expected output: 9
Console.WriteLine("Peek after popping 2 elements: " + stack.Peek()); // Expected output: 8

stack.Push(20);
Console.WriteLine("Peek after pushing 1 element: " + stack.Peek()); // Expected output: 20

// Foreach the left elements
Console.Write("ForEach output: ");
stack.ForEach(item => Console.Write(item + " ")); // Expected output: 1 2 3 4 5 6 7 8 20
Console.WriteLine();

void PushTenElements()
{
    for (int i = 1; i <= 10; i++) stack.Push(i);
}