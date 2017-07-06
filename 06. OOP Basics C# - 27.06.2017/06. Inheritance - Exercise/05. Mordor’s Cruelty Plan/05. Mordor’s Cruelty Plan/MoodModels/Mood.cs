namespace _05.Mordor_s_Cruelty_Plan.MoodModels
{
    public abstract class Mood
    {
        public override string ToString()
        {
            return $"{GetType().Name}";
        }
    }
}