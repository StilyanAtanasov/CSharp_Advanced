// ReSharper disable CheckNamespace
namespace CarManufacturer;

public class Car
{
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
    {
        Make = make;
        Model = model;
        Year = year;
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
        Engine = engine;
        Tires = tires;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }
    public Engine Engine { get; set; }
    public Tire[] Tires { get; set; }

    public void Drive() => FuelQuantity -= FuelConsumption * 0.2; // We drive 20km with fuelConsumption per 100km
    
    public void PrintIfSpecial()
    {
        if (Engine.HorsePower > 330 && Year >= 2017 && Tires.Sum(t => t.Pressure) is >= 9 and <= 10)
        {
            Drive();
            Console.WriteLine($"Make: {Make} \nModel: {Model} \nYear: {Year} \nHorsePowers: {Engine.HorsePower} \nFuelQuantity: {FuelQuantity}");
        }
    }
}