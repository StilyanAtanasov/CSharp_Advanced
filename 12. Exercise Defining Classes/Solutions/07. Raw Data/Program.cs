using _07._Raw_Data;

List<Car> cars = new();

ushort carsCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < carsCount; i++)
{
    string[] car = Console.ReadLine()!.Split();

    string model = car[0];
    int engineSpeed = int.Parse(car[1]);
    int enginePower = int.Parse(car[2]);
    int cargoWeight = int.Parse(car[3]);
    string cargoType = car[4];

    Tire[] tires = new Tire[4];
    for (int j = 0; j < 8; j += 2) tires[j / 2] = new Tire(double.Parse(car[5 + j / 2 * 2]), int.Parse(car[5 + j / 2 * 2 + 1]));

    cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoType, cargoWeight), tires));
}

string wantedType = Console.ReadLine()!; // fragile or flammable
cars = cars.Where(c => c.Cargo.Type == wantedType).ToList();

if (wantedType == "fragile") cars.Where(c => c.Tires.Any(t => t.TirePressure < 1)).ToList().ForEach(c => Console.WriteLine(c.Model));
else cars.Where(c => c.Engine.Power > 250).ToList().ForEach(c => Console.WriteLine(c.Model));