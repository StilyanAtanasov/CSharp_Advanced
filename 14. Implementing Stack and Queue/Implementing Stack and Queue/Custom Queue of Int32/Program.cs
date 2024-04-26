using Custom_Queue_of_Int32;

// Sample Code Usage

CustomQueueOfInt32 queue = new();

// Enqueue some elements
EnqueueTenElements();

// Test Peek
Console.WriteLine("Peek after enqueueing 10 elements: " + queue.Peek()); // Expected output: 1

// Test Dequeue
Console.WriteLine("Dequeue: " + queue.Dequeue()); // Expected output: 10

// Test Peek after Dequeue
Console.WriteLine("Peek after dequeueing 1 element: " + queue.Peek()); // Expected output: 2

// Test Enqueue after Dequeue
queue.Enqueue(20);
Console.WriteLine("Peek after enqueueing 1 element: " + queue.Peek()); // Expected output: 2

// Clear the queue
queue.Clear();
Console.WriteLine("Count after clearing the queue: " + queue.Count); // Expected output: 0

// Test ForEach
EnqueueTenElements();
Console.Write("ForEach output: ");
queue.ForEach(item => Console.Write(item + " ")); // Expected output: 1 2 3 4 5 6 7 8 9 10
Console.WriteLine();

void EnqueueTenElements()
{
    for (int i = 1; i <= 10; i++) queue.Enqueue(i);
}