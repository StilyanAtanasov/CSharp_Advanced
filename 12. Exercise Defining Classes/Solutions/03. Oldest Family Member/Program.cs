// ReSharper disable once CheckNamespace
namespace DefiningClasses;

public class StartUp
{
    public static void Main()
    {
        Family family = new();

        ushort familyMembers = ushort.Parse(Console.ReadLine()!);
        for (int i = 0; i < familyMembers; i++)
        {
            string[] member = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = member[0];
            int age = int.Parse(member[1]);

            family.AddMember(new Person(name, age));
        }

        Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
    }
}