// ReSharper disable All
namespace CarManufacturer;

class Car
{
    private string make;
    private string model;
    private int year;


    public string Make
    {
        get => make;
        set => make = value;
    }

    public string Model
    {
        get => model;
        set => model = value;
    }
    public int Year
    {
        get => year;
        set => year = value;
    }

}
