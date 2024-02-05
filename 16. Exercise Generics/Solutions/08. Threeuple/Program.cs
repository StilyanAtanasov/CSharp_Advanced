using _08._Threeuple;

string[] inputLine = Console.ReadLine()!.Split(); // {first name} {last name} {address} {town}
string names = $"{inputLine[0]} {inputLine[1]}";
string address = inputLine[2];
string town = inputLine[3];

new Threeuple<string, string, string>(names, address, town).Print();

inputLine = Console.ReadLine()!.Split(); // {name} {liters of beer} {drunk or not}
string name1 = inputLine[0];
int litersOfBeer = int.Parse(inputLine[1]);
bool drunkOrNot = inputLine[2] == "drunk";

new Threeuple<string, int, bool>(name1, litersOfBeer, drunkOrNot).Print();

inputLine = Console.ReadLine()!.Split(); // {name} {account balance} {bank name}
string name2 = inputLine[0];
double accountBalance = double.Parse(inputLine[1]);
string bankName = inputLine[2];

new Threeuple<string, double, string>(name2, accountBalance, bankName).Print();