
using System;
using System.Collections.Generic;

public class Topping
{

    private string toppingType;
    private double weight;

    
    public string ToppingType
    {
        get { return this.toppingType; }
        set
        {
            List<string> validToppings = new List<string>{ "meat", "veggies", "cheese", "sauce" };
            if (!validToppings.Contains(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.toppingType = value;
        }
    }

    public double Weight
    {
        

        get { return this.weight; }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
            }
            this.weight = value;
        }
    }

    public double ToppingCalories()
    {
        var typeMod = 0d;
       

        switch (this.toppingType.ToLower())
        {
            case "meat":
                typeMod = 1.2;
                break;
            case "veggies":
                typeMod = 0.8;
                break;
            case "cheese":
                typeMod = 1.1;
                break;
            case "sauce":
                typeMod = 0.9;
                break;
        }
        
        return (2d * this.weight) * typeMod;
    }
}

