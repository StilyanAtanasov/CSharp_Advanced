// ReSharper disable FieldCanBeMadeReadOnly.Local
using System.Collections;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    private List<Book> _books;

    public Library(params Book[] books) => _books = books.OrderBy(b => b).ToList();
    public IEnumerator<Book> GetEnumerator() => new LibraryIterator(_books);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> _books;
        private int _currentIndex = -1;

        public LibraryIterator(List<Book> books) => _books = books;

        public Book Current => _books[_currentIndex];
        object IEnumerator.Current => Current;

        public bool MoveNext() => ++_currentIndex < _books.Count;
        public void Reset() => _currentIndex = -1;
        public void Dispose() => Reset();
    }
}