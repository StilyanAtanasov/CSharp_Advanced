using _05._Date_Modifier;

string date1 = Console.ReadLine()!;
string date2 = Console.ReadLine()!;

DateModifier dateModifier = new(date1, date2);
Console.WriteLine(dateModifier.DayDifference);