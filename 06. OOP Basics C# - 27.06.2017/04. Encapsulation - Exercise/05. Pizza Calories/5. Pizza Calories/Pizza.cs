
using System;
using System.Collections.Generic;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings = new List<Topping>();
    private int numberOfToppings;


    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length > 15 || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public int NumberOfToppings
    {
        get { return numberOfToppings; }
        set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            numberOfToppings = value;
        }
    }
    public Dough Dough
    {
        get { return this.dough; }
        set { this.dough = value; }
    }

    public List<Topping> Toppings
    {
        get { return this.toppings; }
        set { this.toppings = value; }
    }

    public double PizzaCalories()
    {
        var doughCalories = this.dough.DoughCalories();
        var toppingsCallories = 0d;
        for (int i = 0; i < toppings.Count; i++)
        {
            toppingsCallories += toppings[i].ToppingCalories();
        }

        return doughCalories + toppingsCallories;
    }

}

