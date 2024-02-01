// ReSharper disable once CheckNamespace
namespace DefiningClasses;

public class StartUp
{
    public static void Main()
    {
        // Example Usage
        List<Person> people = new()
        {
            new Person(),
            new Person( 0),
            new Person("Sam", 45)
        };

        foreach (Person person in people) Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}