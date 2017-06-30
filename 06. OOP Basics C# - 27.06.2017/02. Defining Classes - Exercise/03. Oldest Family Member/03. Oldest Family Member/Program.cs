
using System;
using System.Collections.Generic;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {

        int num = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < num; i++)
        {
            string[] current = Console.ReadLine().Split();
            Person person = new Person();
            person.Name = current[0];
            person.Age = int.Parse(current[1]);
            family.AddMember(person);
        }

        family.GetOldestMember(family.Members);
    }
}

