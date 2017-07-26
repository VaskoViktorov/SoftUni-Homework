using System.Collections;
using System.Collections.Generic;


public class Library : IEnumerable<Book>
{
    private List<Book> books = new List<Book>();

    public Library(params Book[] books)
    {
        this.Books = books;
    }

    public IReadOnlyList<Book> Books { get; protected set; }

    public IEnumerator<Book> GetEnumerator()
    {
        return this.Books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>();
        }


        public void Dispose(){}

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;
    }
}

