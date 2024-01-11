Queue<string> cars = new();
uint carsToPass = uint.Parse(Console.ReadLine()!);

uint carsPassed = 0;
string command = Console.ReadLine()!;
while (command != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < carsToPass; i++)
        {
            if (cars.Count == 0) break; 
            Console.WriteLine($"{cars.Dequeue()} passed!");
            carsPassed++;
        }
    }
    else cars.Enqueue(command); //command == carArrived

    command = Console.ReadLine()!;
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");