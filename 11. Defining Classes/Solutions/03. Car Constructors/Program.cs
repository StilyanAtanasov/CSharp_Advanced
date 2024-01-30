// ReSharper disable CheckNamespace
namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        // Example Usage
        string make = Console.ReadLine()!;
        string model = Console.ReadLine()!;
        int year = int.Parse(Console.ReadLine()!);
        double fuelQuantity = double.Parse(Console.ReadLine()!);
        double fuelConsumption = double.Parse(Console.ReadLine()!);

        Car firstCar = new();
        Car secondCar = new(make, model, year);
        Car thirdCar = new(make, model, year, fuelQuantity, fuelConsumption);

        Console.WriteLine(firstCar.WhoAmI());
        Console.WriteLine(secondCar.WhoAmI());
        Console.WriteLine(thirdCar.WhoAmI());
    }
}