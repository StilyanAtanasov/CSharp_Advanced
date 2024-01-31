// ReSharper disable CheckNamespace
namespace CarManufacturer;

public class StartUp
{
    public static void Main()
    {
        //TODO: Finish

        List<Tire[]> tiresList = new();

        string command = Console.ReadLine()!;
        while (command != "No more tires")
        {
            string[] tiresSpecs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tire[] tires = new Tire[4];
            for (int i = 0; i < tiresSpecs.Length; i += 2) tires[i / 2] = new Tire(int.Parse(tiresSpecs[i]), double.Parse(tiresSpecs[i + 1]));
            tiresList.Add(tires);

            command = Console.ReadLine()!;
        }

        List<Engine> engineList = new();

        command = Console.ReadLine()!;
        while (command != "Engines done")
        {
            string[] engineSpecs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            engineList.Add(new Engine(int.Parse(engineSpecs[0]), double.Parse(engineSpecs[1])));

            command = Console.ReadLine()!;
        }

        List<Car> cars = new();

        command = Console.ReadLine()!;
        while (command != "Show special")
        {
            string[] carSpecs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string make = carSpecs[0];
            string model = carSpecs[1];
            int year = int.Parse(carSpecs[2]);
            double fuelQuantity = double.Parse(carSpecs[3]);
            double fuelConsumption = double.Parse(carSpecs[4]);
            Engine engine = engineList[int.Parse(carSpecs[5])];
            Tire[] tires = tiresList[int.Parse(carSpecs[6])];

            cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires));

            command = Console.ReadLine()!;
        }

        foreach (Car car in cars) car.PrintIfSpecial();
    }
}