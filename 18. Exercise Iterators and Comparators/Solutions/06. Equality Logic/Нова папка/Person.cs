namespace _06._Equality_Logic;

public class Person : IComparable<Person>
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; }
    public int Age { get; }

    public int CompareTo(Person? other)
    {
        int result = string.Compare(Name, other!.Name, StringComparison.Ordinal);
        if (result == 0) result = Age.CompareTo(other.Age);
        return result;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + Name.GetHashCode();
        hash = hash * 23 + Age.GetHashCode();

        return hash;
    }

    public override bool Equals(object? obj)
    {
        Person other = (obj as Person)!; // For this task Person will only be compared with other Persons
        return Name == other.Name && Age == other.Age;
    }
}