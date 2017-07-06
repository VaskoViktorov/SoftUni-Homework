using _05.Mordor_s_Cruelty_Plan.FoodModels;

namespace _05.Mordor_s_Cruelty_Plan
{
    public static class FoodFactory
    {
        public static Food CreateFood(string foodToString)
        {
            switch (foodToString.ToLower())
            {
                case "cram":
                    return new Cram();

                case "lembas":
                    return new Lembas();

                case "apple":
                    return new Apple();

                case "melon":
                    return new Melon();

                case "honeycake":
                    return new HoneyCake();

                case "mushrooms":
                    return new Mushrooms();

                default:
                    return new Other();
            }
        }
    }
}