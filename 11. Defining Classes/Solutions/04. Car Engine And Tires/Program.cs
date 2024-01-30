// ReSharper disable CheckNamespace
namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        // Example Usage
        Tire[] tires =
        {
            new(1, 2.5),
            new(1, 2.1),
            new(2, 0.5),
            new(2, 2.3)
        };

        Engine engine = new(560, 6300);

        Car car = new("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

        car.Drive(10);
        Console.WriteLine(car.WhoAmI());
    }
}