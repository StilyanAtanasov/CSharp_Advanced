using System.Text;

namespace AutomotiveRepairShop;
public class RepairShop
{
    public RepairShop(int capacity)
    {
        Capacity = capacity;
        Vehicles = new();
    }

    public int Capacity { get; set; }
    public List<Vehicle> Vehicles { get; set; }

    /// <summary>Adds an entity to the collection of Vehicles, if the Capacity allows it.</summary>
    /// <param name="vehicle"></param>
    public void AddVehicle(Vehicle vehicle)
    {
        if (Vehicles.Count < Capacity) Vehicles.Add(vehicle);
    }

    /// <summary>Removes a vehicle by given vin, if such exists, and returns boolean(true if it is removed, otherwise – false)</summary>
    /// <param name="vin"></param>
    /// <returns></returns>
    public bool RemoveVehicle(string vin) => Vehicles.Remove(Vehicles.FirstOrDefault(v => v.VIN == vin)!);

    /// <summary>Returns the number of vehicles, registered in the RepairShop</summary>
    /// <returns></returns>
    public int GetCount() => Vehicles.Count;

    /// <summary>Returns the Vehicle with the lowest value of Mileage property.</summary>
    /// <returns></returns>
    public Vehicle GetLowestMileage() => Vehicles.OrderBy(v => v.Mileage).First();

    /// <summary>Returns a string in the following format: "Vehicles in the preparatory: /n{Vehicle1}/n{Vehicle2}/n(…)"</summary>
    public string Report()
    {
        StringBuilder sb = new();
        sb.AppendLine("Vehicles in the preparatory:");
        foreach (Vehicle vehicle in Vehicles) sb.AppendLine(vehicle.ToString());

        return sb.ToString().TrimEnd();
    }
}