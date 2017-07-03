
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] persons = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
        string[] products = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
        List<Product> productsForSale = new List<Product>();
        List<Person> shoppers = new List<Person>();
        try
        {
            for (int i = 0; i < persons.Length; i += 2)
            {
                Person holder = new Person();
                holder.Name = persons[i];
                holder.Money = double.Parse(persons[i + 1]);
                holder.Products = new List<Product>();
                shoppers.Add(holder);
            }

            for (int i = 0; i < products.Length; i += 2)
            {
                Product holder = new Product(products[i], double.Parse(products[i + 1]));
                productsForSale.Add(holder);
            }
            string[] input = Console.ReadLine().Split(new[] { '\n', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);


            while (input[0] != "END")
            {
                string person = input[0];
                string productName = input[1];

                foreach (var shopper in shoppers)
                {
                    if (shopper.Name.Equals(person))
                    {
                        foreach (var product in productsForSale)
                        {
                            if (product.Name.Equals(productName))
                            {
                                if (shopper.Money - product.Cost >= 0)
                                {
                                    shopper.Money -= product.Cost;
                                    shopper.Products.Add(product);
                                    Console.WriteLine($"{shopper.Name} bought {product.Name}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{shopper.Name} can't afford {product.Name}");
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                input = Console.ReadLine().Split(new[] { '\n', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var shopper in shoppers)
            {
                if (shopper.Products.Count != 0)
                {
                    Console.WriteLine($"{shopper.Name} - {string.Join(", ", shopper.Products.Select(p => p.Name).ToList())}");
                }
                else
                {
                    Console.WriteLine($"{shopper.Name} - Nothing bought");
                }


            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        




    }
}

