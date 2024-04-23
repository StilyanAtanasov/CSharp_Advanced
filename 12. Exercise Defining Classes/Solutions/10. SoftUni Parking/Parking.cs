namespace SoftUniParking;

public class Parking
{
    // ReSharper disable InconsistentNaming -- the task requires these exact names
    private readonly List<Car> cars;
    private readonly int capacity;

    public Parking(int capacity)
    {
        this.capacity = capacity;
        cars = new();
    }

    public int Count => cars.Count;

    public string AddCar(Car car)
    {
        if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber)) return "Car with that registration number, already exists!";
        if (cars.Count == capacity) return "Parking is full!";

        cars.Add(car);
        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }

    public string RemoveCar(string registrationNumber)
    {
        if (cars.All(c => c.RegistrationNumber != registrationNumber)) return "Car with that registration number, doesn't exist!";

        cars.Remove(cars.First(c => c.RegistrationNumber == registrationNumber));
        return $"Successfully removed {registrationNumber}";
    }

    public Car GetCar(string registrationNumber) => cars.First(c => c.RegistrationNumber == registrationNumber);

    public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
    {
        foreach (string registrationNumber in registrationNumbers) RemoveCar(registrationNumber);
    }
}