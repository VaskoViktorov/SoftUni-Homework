using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication265
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = Console.ReadLine().Split().ToArray();
            var phonebook = new Dictionary<string, string>();
            while (contacts[0] != "END")
            {

                if (contacts[0] == "A")
                {
                    if (phonebook.ContainsKey(contacts[1]))
                    {
                        phonebook[contacts[1]] = contacts[2];
                    }

                    else
                    {
                        phonebook.Add(contacts[1], contacts[2]);
                    }
                }
                else if (contacts[0] == "S")
                {
                    if (phonebook.ContainsKey(contacts[1]))
                    {

                        Console.WriteLine($"{contacts[1]} -> {phonebook[contacts[1]]}");
                    }

                    else
                    {


                        Console.WriteLine($"Contact {contacts[1]} does not exist.");


                    }


                }
                else if (contacts[0] == "ListAll")
                {
                     

                    foreach (KeyValuePair<string, string> i in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{i.Key} -> {i.Value}");
                    }
                }
                contacts = Console.ReadLine().Split().ToArray();

            }
        }
    }
}
