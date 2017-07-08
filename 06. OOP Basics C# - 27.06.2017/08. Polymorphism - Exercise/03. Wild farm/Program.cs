using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                List<Animal> animal = new List<Animal>();
                switch (input[0])
                {
                    case "Cat":
                        Animal cat = new Cat(input[1], input[0], double.Parse(input[2]), 0, input[3], input[4]);
                        animal.Add(cat);
                        break;
                    case "Tiger":
                        Animal tiger = new Tiger(input[1], input[0], double.Parse(input[2]), 0, input[3]);
                        animal.Add(tiger);
                        break;
                    case "Mouse":
                        Animal mouse = new Mouse(input[1], input[0], double.Parse(input[2]), 0, input[3]);
                        animal.Add(mouse);
                        break;
                    case "Zebra":
                        Animal zebra = new Zebra(input[1], input[0], double.Parse(input[2]), 0, input[3]);
                        animal.Add(zebra);
                        break;
                }

                input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "Meat":
                        Food meat = new Meat(int.Parse(input[1]), input[0]);
                        foreach (var one in animal)
                        {
                            one.MakeSound();
                            try
                            {
                                one.EatFood(meat);
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);                               
                            }
                            Console.WriteLine(one.ToString());

                        }
                        break;
                    case "Vegetable":
                        Food vegetable = new Vegetable(int.Parse(input[1]), input[0]);

                        foreach (var one in animal)
                        {
                            one.MakeSound();
                            try
                            {
                                one.EatFood(vegetable);
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }
                            Console.WriteLine(one.ToString());
                            

                        }

                        break;
                }

                animal.Clear();

                input = Console.ReadLine().Split();
            }
        }
    }
}
