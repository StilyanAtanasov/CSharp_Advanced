using _06._Speed_Racing;

List<Car> cars = new();

ushort carsCount = ushort.Parse(Console.ReadLine()!);
for (int i = 0; i < carsCount; i++)
{
    string[] car = Console.ReadLine()!.Split();
    string model = car[0];
    double fuelAmount = double.Parse(car[1]);
    double fuelConsumptionPerKilometer = double.Parse(car[2]);

    cars.Add(new Car(model, fuelAmount, fuelConsumptionPerKilometer));
}

string command;
while ((command = Console.ReadLine()!) != "End")
{
    string[] carToDrive = command.Split(); // index 0 is always "Drive"
    string model = carToDrive[1];
    double distance = double.Parse(carToDrive[2]);

    cars.First(c => c.Model == model).Drive(distance);
}

foreach (Car car in cars) Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");