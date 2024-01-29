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
            Year = 1992
        };

        Console.WriteLine($"Make: {car.Make} \nModel: {car.Model} \nYear: {car.Year}");
    }
}
