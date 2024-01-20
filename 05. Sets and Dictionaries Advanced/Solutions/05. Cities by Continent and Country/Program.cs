Dictionary<string, Dictionary<string, List<string>>> citiesCollection = new();

byte commandsCount = byte.Parse(Console.ReadLine()!);
for (int i = 0; i < commandsCount; i++)
{
    string[] cityInfo = Console.ReadLine()!.Split();
    string cityContinent = cityInfo[0];
    string cityCountry = cityInfo[1];
    string cityName = cityInfo[2];

    if (!citiesCollection.ContainsKey(cityContinent)) citiesCollection[cityContinent] = new Dictionary<string, List<string>>();
    if (!citiesCollection[cityContinent].ContainsKey(cityCountry)) citiesCollection[cityContinent][cityCountry] = new List<string>();
    citiesCollection[cityContinent][cityCountry].Add(cityName);
}

foreach (var (continent, countries) in citiesCollection)
{
    Console.WriteLine($"{continent}:");
    foreach (var (country, cities) in countries) Console.WriteLine($"\t{country} -> {string.Join(", ", cities)}");
}