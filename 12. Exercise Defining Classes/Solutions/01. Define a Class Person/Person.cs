// ReSharper disable All
namespace DefiningClasses;
public class Person
{
    private string name = null!;
	private byte age;

	public string Name
	{
		get => name;
        set => name = value;
    }

    public byte Age
	{
		get => age;
        set => age = value;
    }
}