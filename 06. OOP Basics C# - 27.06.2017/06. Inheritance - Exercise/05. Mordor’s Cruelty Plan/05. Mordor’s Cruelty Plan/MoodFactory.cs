using _05.Mordor_s_Cruelty_Plan.FoodModels;
using _05.Mordor_s_Cruelty_Plan.MoodModels;
using System.Collections.Generic;
using System.Linq;

namespace _05.Mordor_s_Cruelty_Plan
{
    public static class MoodFactory
    {
        public static Mood CreateMood(List<Food> foods)
        {
            var indexOfHappines = foods.Sum(f => f.PointOfHappines);

            if (indexOfHappines < -5)
            {
                return new Angry();
            }
            else if (indexOfHappines >= -5 && indexOfHappines <= 0)
            {
                return new Sad();
            }
            else if (indexOfHappines >= 1 && indexOfHappines <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}