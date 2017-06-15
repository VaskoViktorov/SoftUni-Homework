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

            string[] commands = Console.ReadLine().Split(new[] { ' ', '\t', '\n',';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, List<string>> holder= new Dictionary<string, List<string>>();
            while (commands[0] != "Print")
            {

                if (commands[2] == "Starts")
                {
                    guests = StartsWith(guests, commands, holder);
                }
                else if (commands[2] == "Ends")
                {
                    guests = EndsWith(guests, commands, holder);
                }
                else if (commands[2] == "Length")
                {
                    guests = Length(guests, commands, holder);
                }
                else if (commands[2] == "Contains")
                {
                    guests = Contains(guests, commands, holder);
                }


                commands = Console.ReadLine().Split(new[] { ' ', '\t', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            if (guests.Count != 0)
            {
                Console.WriteLine($"{string.Join(" ", guests)}");
            }

        }

        static List<string> StartsWith(List<string> guests, string[] command, Dictionary<string, List<string>> holder)
        {                      
            var key = $"{command[2]} {command[3]};{command[4]}";

            if (command[0] == "Add")
            {
                string word = command.Last();
                Regex regStart = new Regex($"\\b{word}");
                if (!holder.ContainsKey(key))
                {
                    holder.Add(key, guests.Where(h => regStart.IsMatch(h)).ToList());
                }
                
                guests.RemoveAll(h => regStart.IsMatch(h));
                
            }
            else if (command[0] == "Remove")
            {
                if (holder.ContainsKey(key))
                {
                    List<string> newGuests = new List<string>();
                    newGuests = holder[key];
                    holder.Remove(key);
                    newGuests.AddRange(guests);
                    return newGuests;
                }
            }
            return guests;
        }

        static List<string> EndsWith(List<string> guests, string[] command, Dictionary<string, List<string>> holder)
        {                    
            var key = $"{command[2]} {command[3]};{command[4]}";

            if (command[0] == "Add")
            {
                string word = command.Last();
                Regex regEnd = new Regex($"{word}\\b");
                if (!holder.ContainsKey(key))
                {
                    holder.Add(key, guests.Where(h => regEnd.IsMatch(h)).ToList());
                }
                guests.RemoveAll(h => regEnd.IsMatch(h));
            }
            else if (command[0] == "Remove")
            {
                if (holder.ContainsKey(key))
                {
                    List<string> newGuests = new List<string>();
                    newGuests = holder[key];
                    newGuests.AddRange(guests);
                    return newGuests;
                }
            }
            return guests;
        }

        static List<string> Length(List<string> guests, string[] command, Dictionary<string, List<string>> holder)
        {           
            var key = $"{command[2]};{command[3]}";
            
            if (command[0] == "Add")
            {
                long num = long.Parse(command[3]);
                if (!holder.ContainsKey(key))
                {
                    holder.Add(key, guests.Where(h => h.Length == num).ToList());
                }
                guests.RemoveAll(h => h.Length == num);
            }
            else if (command[0] == "Remove")
            {
                if (holder.ContainsKey(key))
                {
                    List<string> newGuests = new List<string>();
                    newGuests = holder[key];
                    newGuests.AddRange(guests);
                    return newGuests;
                }
            }
            return guests;
        }

        static List<string> Contains(List<string> guests, string[] command, Dictionary<string, List<string>> holder)
        {           
            var key = $"{command[2]};{command[3]}";            

            if (command[0] == "Add")
            {
                string txt = command[3];
                if (!holder.ContainsKey(key))
                {
                    holder.Add(key, guests.Where(h => h.Contains(txt)).ToList());
                }
                guests.RemoveAll(h => h.Contains(txt));
            }
            else if (command[0] == "Remove")
            {
                if (holder.ContainsKey(key))
                {
                    List<string> newGuests = new List<string>();
                    newGuests = holder[key];
                    newGuests.AddRange(guests);
                    return newGuests;
                }
            }
            return guests;
        }
    }
}
