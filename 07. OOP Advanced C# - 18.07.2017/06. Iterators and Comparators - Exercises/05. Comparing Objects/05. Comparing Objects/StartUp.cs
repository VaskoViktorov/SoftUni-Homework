using System;
using System.Collections.Generic;

namespace _05.Comparing_Objects
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var personTokens = input.Split();
                Person person = new Person(personTokens[0], personTokens[1], personTokens[2]);
                persons.Add(person);
            }

            var currPerson = int.Parse(Console.ReadLine());

            if (currPerson > persons.Count - 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int equal = 0;
                int notEqual = 0;

                foreach (var person in persons)
                {
                    if (persons[currPerson].CompareTo(person) == 0)
                    {
                        equal++;
                    }
                    else
                    {
                        notEqual++;
                    }
                }

                Console.WriteLine($"{equal} {notEqual} {persons.Count}");
            }           
        }
    }
}
