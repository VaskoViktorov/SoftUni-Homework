using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
    public class Cat : Felime
    {
        private string catBreed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string catBreed) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            this.CatBreed = catBreed;
        }

        public string CatBreed
        {
            get { return this.catBreed; }
            set { this.catBreed = value; }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void EatFood(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.AnimalType}[{this.AnimalName}, {this.CatBreed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
