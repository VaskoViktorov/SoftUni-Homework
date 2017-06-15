using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (commands[0] != "Party!")
            {

                if (commands[1] == "StartsWith")
                {
                    guests = StartsWith(guests, commands);
                }
                else if (commands[1] == "EndsWith")
                {
                    guests = EndsWith(guests, commands);
                }
                else if (commands[1] == "Length")
                {
                    guests = Length(guests, commands);
                }


                commands = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            if (guests.Count != 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }           
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static List<string> StartsWith(List<string> guests, string[] command)
        {
            string word = command[2];
            Regex regStart = new Regex($"\\b{word}");
            List<string> newGuests = new List<string>();

            if (command[0] == "Remove")
            {
                guests.RemoveAll(h => regStart.IsMatch(h));
            }
            else if (command[0] == "Double")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (regStart.IsMatch(guests[i]))
                    {
                        newGuests.Add(guests[i]);
                    }
                }
                newGuests.AddRange(guests);
                return newGuests;
            }
            return guests;
        }

        static List<string> EndsWith(List<string> guests, string[] command)
        {
            string word = command[2];
            Regex regEnd = new Regex($"{word}\\b");          
            List<string> newGuests = new List<string>();

            if (command[0] == "Remove")
            {
                guests.RemoveAll(h => regEnd.IsMatch(h));
            }
            else if (command[0] == "Double")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (regEnd.IsMatch(guests[i]))
                    {
                        newGuests.Add(guests[i]);
                    }
                }
                newGuests.AddRange(guests);
                return newGuests;
            }
            return guests;
        }

        static List<string> Length(List<string> guests, string[] command)
        {
            long num = long.Parse(command[2]);
            
            List<string> newGuests = new List<string>();

            if (command[0] == "Remove")
            {
                guests.RemoveAll(h => h.Length == num);
            }
            else if (command[0] == "Double")
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    if (guests[i].Length == num)
                    {
                        newGuests.Add(guests[i]);
                    }
                }
                newGuests.AddRange(guests);
                return newGuests;
            }
            return guests;
        }
    }
}
