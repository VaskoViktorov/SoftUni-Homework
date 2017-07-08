using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = foodEaten;
        }
        
        protected string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        protected string AnimalType
        {
            get { return this.animalType; }
            set { this.animalType = value; }
        }

        protected double AnimalWeight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }

        protected int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        public abstract void MakeSound();

        public abstract void EatFood(Food food);

        public override string ToString()
        {
            return "";
        }
    }
}
