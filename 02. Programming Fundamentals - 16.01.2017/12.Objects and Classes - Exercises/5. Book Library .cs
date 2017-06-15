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

            Dictionary<string, decimal> listOfAuthors = new Dictionary<string, decimal>();

            for (int i = 0; i < bookShelf.Books.Count; i++)
            {
                if (!listOfAuthors.ContainsKey(bookShelf.Books[i].Author))
                {
                    listOfAuthors.Add(bookShelf.Books[i].Author, bookShelf.Books[i].Price);
                }
                else
                {
                    listOfAuthors[bookShelf.Books[i].Author] += bookShelf.Books[i].Price;
                }
            }

            foreach (var item in listOfAuthors.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
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
