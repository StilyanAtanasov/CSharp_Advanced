namespace _06._Speed_Racing;

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
    }

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TraveledDistance { get; set; }

    public void Drive(double distance)
    {
        if (distance * FuelConsumptionPerKilometer <= FuelAmount)
        {
            FuelAmount -= distance * FuelConsumptionPerKilometer;
            TraveledDistance += distance;
        }
        else Console.WriteLine("Insufficient fuel for the drive");
    }
}