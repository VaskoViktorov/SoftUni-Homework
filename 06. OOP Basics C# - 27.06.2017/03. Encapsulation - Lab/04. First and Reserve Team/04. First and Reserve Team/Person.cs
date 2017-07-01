
using System;
using System.Collections.Generic;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
            this.lastName = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
            this.age = value;
        }
    }

    public double Salary
    {
        get { return this.salary; }
        set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }
            this.salary = value;
        }
    }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary} leva";

    }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age > 30)
        {
            this.Salary += this.Salary * (bonus / 100);
        }
        else
        {
            this.Salary += this.Salary * (bonus / 2 / 100);
        }
    }
}

