// ReSharper disable FieldCanBeMadeReadOnly.Local
using System.Collections;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    private List<Book> _books;

    public Library(params Book[] books) => this._books = books.ToList();
    public IEnumerator<Book> GetEnumerator() => _books.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}