namespace Custom_Linked_List_Of_Int32;

public class Node
{
    public Node (int value) => Value = value;

    public int Value { get; set; }
    public Node? Next { get; set; }
    public Node? Previous { get; set; }

}