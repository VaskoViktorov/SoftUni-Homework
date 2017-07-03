
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        Dough doughForPizza = new Dough();
        List<Topping> addedToppings = new List<Topping>();
        Pizza pizza = new Pizza();
        var isPizza = false;
      
        try
        {
            while (input[0] != "END")
            {
                if (input[0] == "Dough")
                {
                    Dough dough = new Dough();
                    dough.FlourType = input[1];
                    dough.BakingTechnique = input[2];
                    dough.Weight = double.Parse(input[3]);
                    doughForPizza = dough;
                    if (!isPizza)
                    {
                        Console.WriteLine($"{dough.DoughCalories():f2}");
                    }
                }
                else if (input[0] == "Topping")
                {

                    Topping topping = new Topping();
                    topping.ToppingType = input[1];
                    topping.Weight = double.Parse(input[2]);
                    addedToppings.Add(topping);
                    if (!isPizza)
                    {
                        Console.WriteLine($"{topping.ToppingCalories():f2}");
                    }
                }
                else if (input[0] == "Pizza")
                {
                    isPizza = true;
                    pizza.Name = input[1];
                    pizza.NumberOfToppings = int.Parse(input[2]);
                }

                input = Console.ReadLine().Split();
            }
            if (!string.IsNullOrWhiteSpace(pizza.Name))
            {
                pizza.Dough = doughForPizza;
                pizza.Toppings = addedToppings;
                Console.WriteLine($"{pizza.Name} - {pizza.PizzaCalories():f2} Calories.");
            }           
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

