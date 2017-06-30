
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public static void Above30(List<Person> list)
    {
        var filtered = list.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        foreach (var person in filtered)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

