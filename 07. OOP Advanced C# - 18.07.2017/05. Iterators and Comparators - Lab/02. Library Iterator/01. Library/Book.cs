using System.Collections.Generic;


    public class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; protected set; }

        public int Year { get; protected set; }

        public IReadOnlyList<string> Authors { get; protected set; }

    }

