﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void EatFood(Food food)
        {
            if (food.Type == "Vegetable")
            {
                throw new ArgumentException($"{this.AnimalType}s are not eating that type of food!");
            }
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
