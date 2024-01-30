// ReSharper disable CheckNamespace
namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        // Example Usage
        Car car = new()
        {
            Make = "VW",
            Model = "MK3",
            Year = 1992,
            FuelQuantity = 200,
            FuelConsumption = 200
        };

        car.Drive(2000);
        Console.WriteLine(car.WhoAmI());
    }
}