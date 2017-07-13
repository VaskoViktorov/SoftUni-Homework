
    public class TimeLimitRace : Race
    {
        private int goldTime;

        public TimeLimitRace(int length, string route, int prizePool, int goldTime) : base(length, route, prizePool)
        {
            this.GoldTime = goldTime;
        }

        public int GoldTime
        {
            get { return this.goldTime; }
            set { this.goldTime = value; }
        }
        public override string PerformancePoints(Car car)
        {
            var prize = string.Empty;
            var time = this.Length * ((car.Horsepower / 100) * car.Acceleration);

            if (goldTime >= time)
            {
                prize = "Gold";
            }
            else if (goldTime + 15 >= time)
            {
                prize = "Silver";
            }
            else
            {
                prize = "Bronze";
            }
            return $"{time} s.\n{prize} Time";
        }
    }

