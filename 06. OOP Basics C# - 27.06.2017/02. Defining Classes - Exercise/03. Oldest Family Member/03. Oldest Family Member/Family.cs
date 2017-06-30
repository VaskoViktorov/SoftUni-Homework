
using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{
    public List<Person> members = new List<Person>();

    public List<Person> Members
    {
        get { return this.members; }
        set { this.members = value; }
    }

    public void AddMember(Person member)
    {
        members.Add(member);
    }
    public void GetOldestMember(List<Person> members)
    {
        int age = members.Max(x => x.Age);
        var oldestMembers = members.Where(x => x.Age == age);

        foreach (var member in oldestMembers)
        {
            Console.WriteLine($"{member.Name} {member.Age}");
            break;
        }

    }
}

