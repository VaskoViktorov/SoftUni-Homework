using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
   public abstract class Mamal : Animal
   {
       private string livingRegion;
        public Mamal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }

       public string LivingRegion
       {
            get { return this.livingRegion; }
            set { this.livingRegion = value; }
       }


    }
}
