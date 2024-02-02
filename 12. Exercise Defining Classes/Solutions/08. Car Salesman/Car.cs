using System.Text;

namespace _08._Car_Salesman;

public class Car
{
    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
        Weight = int.MinValue;
        Color = "n/a";
    }

    public Car(string model, Engine engine, int weight, string color) : this(model, engine)
    {
        Weight = weight;
        Color = color;
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }

    public void PrintCarSpecs()
    {
        string weight = Weight == int.MinValue ? "n/a" : Weight.ToString();
        string displacement = Engine.Displacement == int.MinValue ? "n/a" : Engine.Displacement.ToString();

        StringBuilder sb = new();
        sb.AppendLine($"{Model}:");
        sb.AppendLine($"  {Engine.Model}:");
        sb.AppendLine($"    Power: {Engine.Power}");
        sb.AppendLine($"    Displacement: {displacement}");
        sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
        sb.AppendLine($"  Weight: {weight}");
        sb.AppendLine($"  Color: {Color}");

        Console.WriteLine(sb.ToString().TrimEnd());
    }
}