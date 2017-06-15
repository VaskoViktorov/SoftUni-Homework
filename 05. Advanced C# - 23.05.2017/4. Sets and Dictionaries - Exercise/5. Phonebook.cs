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
            var contacts = Console.ReadLine().Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            var phonebook = new Dictionary<string, string>();

            while (contacts[0] != "search")
            {
                string name = contacts[0];
                string phone = contacts[1];

                if (phonebook.ContainsKey(name))
                {
                    phonebook[contacts[0]] = contacts[1];
                }
                else
                {
                    phonebook.Add(contacts[0], contacts[1]);
                }

                contacts = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            }
            string contactName = Console.ReadLine();        
            bool existName = false;

            while (contactName != "stop")
            {               
                foreach (var phone in phonebook)
                {
                    if (phone.Key == contactName)
                    {
                        Console.WriteLine($"{phone.Key} -> {phone.Value}");
                        existName = true;
                        break;
                    }

                }
                if(!existName)
                {
                    Console.WriteLine($"Contact {contactName} does not exist.");
                    
                }
                existName = false;
                contactName = Console.ReadLine();
            }   
        }
    }
}
