using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication285
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Library bookShelf = ReadInput(num);
            DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            Dictionary<string, DateTime> ListOfBooks = new Dictionary<string, DateTime>();

            for (int i = 0; i < bookShelf.Books.Count; i++)
            {
                if (bookShelf.Books[i].ReleaseDate > startTime)
                {
                    ListOfBooks.Add(bookShelf.Books[i].Title, bookShelf.Books[i].ReleaseDate);
                }
               
            }

            foreach (var item in ListOfBooks.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:dd.MM.yyyy}");
            }



        }
        static Library ReadInput(int num)
        {
            Library bookShelf = new Library() { Name = "bookShelf", Books = new List<Book>() };
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", null);
                book.ISBN = input[4];
                book.Price = decimal.Parse(input[5]);
                bookShelf.Books.Add(book);
            }
            return bookShelf;
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }


    }
}
