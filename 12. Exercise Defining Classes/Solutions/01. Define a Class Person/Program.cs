// ReSharper disable once CheckNamespace
namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        // Example Usage
        List<Person> people = new()
        {
            new Person {Name = "Peter", Age = 20},
            new Person {Name = "George", Age = 18},
            new Person {Name = "Jose", Age = 43}
        };

        foreach (Person person in people) Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}