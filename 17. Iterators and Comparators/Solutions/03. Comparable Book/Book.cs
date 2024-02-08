namespace IteratorsAndComparators;

public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }

    public override string ToString() => $"{Title} - {Year}";
    public int CompareTo(Book? other)
    {
        int result = Year.CompareTo(other!.Year);
        if (result == 0) result = string.Compare(Title, other.Title, StringComparison.Ordinal);
        return result;
    }
}