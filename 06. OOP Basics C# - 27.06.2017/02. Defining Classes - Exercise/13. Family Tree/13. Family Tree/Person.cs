using System.Collections.Generic;

public class Person
{
    private string name;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person(string name, string birthDay)
    {
        this.Name = name;
        this.Birthday = birthDay;
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public string Birthday
    {
        get
        {
            return this.birthday;
        }
        set
        {
            this.birthday = value;
        }
    }

    public List<Person> Parents
    {
        get
        {
            return this.parents;
        }
        set
        {
            this.parents = value;
        }
    }

    public List<Person> Children
    {
        get
        {
            return this.children;
        }
        set
        {
            this.children = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Birthday}";
    }
}