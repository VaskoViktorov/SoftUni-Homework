using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication278
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] text = new string[] {
                //Phrases
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product.", 
                //Events
               "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!",
               //Authors
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva",
               //Cities
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            Random rnd = new Random();      
            for (int i = 0; i < num; i++)
            {
                int phrases = rnd.Next(0, 5);
                int events = rnd.Next(6, 11);
                int authors = rnd.Next(12, 19);
                int cities = rnd.Next(20, 24);
                Console.WriteLine($"{text[phrases]} {text[events]} {text[authors]} – {text[cities]}");
            }

        }
    }
}
