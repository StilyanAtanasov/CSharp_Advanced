string[] inputLine = Console.ReadLine()!.Split(); // {first name} {last name} {address}
string names = $"{inputLine[0]} {inputLine[1]}";
string address = inputLine[2];

new _07._Tuple.Tuple<string, string>(names, address).Print();

inputLine = Console.ReadLine()!.Split(); // {name} {liters of beer}
string name = inputLine[0];
int litersOfBeer = int.Parse(inputLine[1]);

new _07._Tuple.Tuple<string, int>(name, litersOfBeer).Print();

inputLine = Console.ReadLine()!.Split(); // {integer} {double}
int integer = int.Parse(inputLine[0]);
double @double = double.Parse(inputLine[1]);

new _07._Tuple.Tuple<int, double>(integer, @double).Print();