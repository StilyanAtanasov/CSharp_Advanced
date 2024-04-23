using System.Globalization;

namespace _05._Date_Modifier;

public class DateModifier
{
    private readonly string _date1;
    private readonly string _date2;

    public DateModifier(string date1, string date2)
    {
        _date1 = date1;
        _date2 = date2;
    }

    public uint DayDifference => CalculateDayDifference();

    private uint CalculateDayDifference()
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime date1 = DateTime.ParseExact(_date1, "yyyy MM dd", provider);
        DateTime date2 = DateTime.ParseExact(_date2, "yyyy MM dd", provider);

        uint difference = (uint)Math.Abs((date1 - date2).Days);

        return difference;
    }
}