using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        List<Person> persons = new List<Person>();
        for (int i = 0; i < num; i++)
        {
            string[] current = Console.ReadLine().Split();
            Person holder = new Person();
            holder.Name = current[0];
            holder.Age = int.Parse(current[1]);
            persons.Add(holder);

        }

        Person.Above30(persons);
        
    }
}
