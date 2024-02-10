using _05._Comparing_Objects;

List<Person> people = new();

string command;
while ((command = Console.ReadLine()!) != "END")
{
    string[] personInfo = command.Split();
    people.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));
}

byte personIndex = (byte) (byte.Parse(Console.ReadLine()!) - 1); // count starts from 1
int matches = -1; // there always be one match (the same person)
foreach (Person person in people) if (person.CompareTo(people[personIndex]) == 0) matches++;

Console.WriteLine(matches == 0 ? "No matches" : $"{++matches} {people.Count - matches} {people.Count}"); // here the same person counts