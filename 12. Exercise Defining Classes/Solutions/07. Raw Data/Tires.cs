namespace _07._Raw_Data;

public class Tire
{
    public Tire(double tirePressure, int tireAge)
    {
        TirePressure = tirePressure;
        TireAge = tireAge;
    }

    public int TireAge { get; set; }
    public double TirePressure { get; set; }
}