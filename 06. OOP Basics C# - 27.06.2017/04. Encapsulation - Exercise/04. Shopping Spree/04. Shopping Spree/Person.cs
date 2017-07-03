
using System;
using System.Collections.Generic;

class Person
{
    private string name;
    private double money;
    private List<Product> products;


    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public double Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public List<Product> Products
    {
        get
        {
            return this.products;
        }
        set
        {

            this.products = value;
        }
    }
}

