// ReSharper disable once CheckNamespace
using BoxOfT;

// Example Usage
Box<int> box = new Box<int>();
box.Add(1);
box.Add(2);
box.Add(3);
Console.WriteLine(box.Count);
Console.WriteLine(box.Remove());
box.Add(4);
box.Add(5);
Console.WriteLine(box.Remove());
Console.WriteLine(box.Count);