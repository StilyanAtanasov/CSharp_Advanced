using Custom_List_of_Int32;

// Sample Code Usage

CustomListOfInt32 list = new();

// Add elements until the array needs to be enlarged
for (int i = 1; i <= 10; i++) list.Add(i);
Console.WriteLine("Initial capacity: " + list.Count); // Expected output: 10

// Remove some elements to trigger shrink
for (int i = 0; i < 5; i++) list.RemoveAt(list.Count - 1);
Console.WriteLine("Capacity after removing elements: " + list.Count); // Expected output: 5

// Test RemoveAt
Console.WriteLine("Removed element at index 1: " + list.RemoveAt(1)); // Expected output: 2

// Test indexing after RemoveAt
Console.WriteLine("Element at index 1 after removal: " + list[1]); // Expected output: 3

// Insert an element
list.Insert(1, 2);
Console.WriteLine("Element at index 1 after insertion: " + list[1]); // Expected output: 2

// Test Contains
Console.WriteLine("Contains 2? " + list.Contains(1)); // Expected output: True
Console.WriteLine("Contains 4? " + list.Contains(100)); // Expected output: False

// Test Swap
list.Swap(0, 2);
Console.WriteLine("Element at index 0 after swap: " + list[0]); // Expected output: 3
Console.WriteLine("Element at index 2 after swap: " + list[2]); // Expected output: 1