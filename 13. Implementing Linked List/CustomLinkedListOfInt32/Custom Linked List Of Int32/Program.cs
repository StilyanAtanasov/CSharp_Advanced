using Custom_Linked_List_Of_Int32;

// ------ Example Usage ------

// -- Valid Operations
CustomLinkedListOfInt32 linkedList = new();

// Add last
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);

// Remove last
linkedList.RemoveLast();

// Add first
linkedList.AddFirst(0);

// Remove first
linkedList.RemoveFirst();

// ForEach
linkedList.ForEach(e => Console.Write(e + " "));
Console.WriteLine();

// Array Conversion
int[] array = linkedList.ToArray();
Console.WriteLine(string.Join(", ", array));


// -- Invalid Operations
linkedList = new();

// Remove while there are no elements
linkedList.RemoveLast();