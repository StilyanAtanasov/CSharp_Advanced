using System.Globalization;

SortedDictionary<string, Dictionary<string, double>> shops = new();

string command = Console.ReadLine()!;
while (command != "Revision")
{
    string[] productInfo = command.Split(", ");
    string shop = productInfo[0];
    string product = productInfo[1];
    double price = double.Parse(productInfo[2]);

    if (!shops.ContainsKey(shop)) shops[shop] = new Dictionary<string, double>();
    shops[shop].Add(product, price);

    command = Console.ReadLine()!;
}

foreach (var (shopName, products) in shops)
{
    Console.WriteLine($"{shopName}->");
    foreach (var (productName, productPrice) in products) Console.WriteLine($"Product: {productName}, Price: {productPrice}");
}