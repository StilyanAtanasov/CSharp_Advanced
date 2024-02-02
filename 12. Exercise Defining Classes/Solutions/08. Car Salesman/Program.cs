using _08._Car_Salesman;

List<Engine> engines = new();

ushort enginesCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < enginesCount; i++)
{
    string[] engineProps = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries); // model, power, displacement?, efficiency?

    Engine engine = new Engine(engineProps[0], int.Parse(engineProps[1]));
    if (engineProps.Length == 4)
    {
        engine.Displacement = int.Parse(engineProps[2]);
        engine.Efficiency = engineProps[3];
    }
    else if (engineProps.Length == 3)
    {
        if (int.TryParse(engineProps[2], out int displacement)) engine.Displacement = displacement;
        else engine.Efficiency = engineProps[2];
    }

    engines.Add(engine);
}

List<Car> cars = new();

ushort carsCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < carsCount; i++)
{
    string[] carProps = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries); // model, engine, weight?, color?

    Car car = new Car(carProps[0], engines.First(e => e.Model == carProps[1]));
    if (carProps.Length == 4)
    {
       car.Weight = int.Parse(carProps[2]);
       car.Color = carProps[3];
    }
    else if (carProps.Length == 3)
    {
        if (int.TryParse(carProps[2], out int weight)) car.Weight = weight;
        else car.Color = carProps[2];
    }

    cars.Add(car);
}

foreach (Car car in cars) car.PrintCarSpecs();