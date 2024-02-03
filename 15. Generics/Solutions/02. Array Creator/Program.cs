using GenericArrayCreator;

// Example Usage
Console.WriteLine(string.Join(", ", ArrayCreator.Create(10, 5)));

string[] strings = ArrayCreator.Create(5, "string");
Console.WriteLine(string.Join(", ", strings));

List<DateTime> dateTimes = ArrayCreator.Create(5, DateTime.Now).ToList();
Console.WriteLine(string.Join(", ", dateTimes));