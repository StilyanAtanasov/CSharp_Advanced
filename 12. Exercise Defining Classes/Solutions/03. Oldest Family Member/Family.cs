// ReSharper disable All
namespace DefiningClasses;
public class Family
{
    public List<Person> familyMembers { get; set; } = new List<Person>();

    public void AddMember(Person person) => familyMembers.Add(person);
    public Person GetOldestMember() => familyMembers.OrderByDescending(p => p.Age).FirstOrDefault()!;
}