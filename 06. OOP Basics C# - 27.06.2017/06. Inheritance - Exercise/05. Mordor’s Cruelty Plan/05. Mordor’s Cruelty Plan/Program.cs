using _05.Mordor_s_Cruelty_Plan.FoodModels;
using _05.Mordor_s_Cruelty_Plan.MoodModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Mordor_s_Cruelty_Plan
{

    public class Startup
    {
        public static void Main()
        {
            var foods = new List<Food>();

            var foodTokens = Regex.Split(Console.ReadLine(), @"\s+");

            foreach (var foodToken in foodTokens)
            {
                var currentFood = FoodFactory.CreateFood(foodToken);
                foods.Add(currentFood);
            }

            Mood mood = MoodFactory.CreateMood(foods);

            Console.WriteLine(foods.Sum(f => f.PointOfHappines));
            Console.WriteLine(mood);
        }
    }
}