using _06._Equality_Logic;

int inputLines = int.Parse(Console.ReadLine()!);

SortedSet<Person> sortedSet = new();
HashSet<Person> hashSet = new();

for (int i = 0; i < inputLines; i++)
{
    string[] personInfo = Console.ReadLine()!.Split();
    string name = personInfo[0];
    int age = int.Parse(personInfo[1]);

    Person person = new(name, age);

    sortedSet.Add(person);
    hashSet.Add(person);
}

Console.WriteLine(sortedSet.Count);
Console.WriteLine(hashSet.Count);