namespace _05.Mordor_s_Cruelty_Plan.FoodModels
{
    public abstract class Food
    {
        private int pointOfHappines;

        protected Food(int pointOfHappines)
        {
            this.PointOfHappines = pointOfHappines;
        }

        public virtual int PointOfHappines
        {
            get { return pointOfHappines; }
            set { pointOfHappines = value; }
        }
    }
}