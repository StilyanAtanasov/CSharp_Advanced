using CustomDoublyLinkedList;

// ------ Example Usage for Int32 ------

// -- Valid Operations
try
{
    DoublyLinkedList<int> linkedList = new();

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
    Console.WriteLine(linkedList.Count);

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
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}