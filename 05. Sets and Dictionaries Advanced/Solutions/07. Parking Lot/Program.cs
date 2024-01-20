HashSet<string> parkingLot = new();

string command = Console.ReadLine()!;
while (command != "END")
{
    string[] carOperation = command.Split(", ");
    string direction = carOperation[0];
    string carNumber = carOperation[1];

    if (direction == "IN") parkingLot.Add(carNumber);
    else parkingLot.Remove(carNumber);

    command = Console.ReadLine()!;
}

Console.WriteLine(parkingLot.Count == 0 ? "Parking Lot is Empty" : string.Join("\n", parkingLot));