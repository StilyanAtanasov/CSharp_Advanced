// ReSharper disable once CheckNamespace
namespace DefiningClasses;

public class StartUp
{
    public static void Main()
    {
        List<Person> people = new();

        ushort familyMembers = ushort.Parse(Console.ReadLine()!);
        for (int i = 0; i < familyMembers; i++)
        {
            string[] member = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = member[0];
            int age = int.Parse(member[1]);

            people.Add(new Person(name, age));
        }

        foreach (Person person in people.Where(p => p.Age > 30).OrderBy(p => p.Name)) Console.WriteLine($"{person.Name} - {person.Age}");
    }
}