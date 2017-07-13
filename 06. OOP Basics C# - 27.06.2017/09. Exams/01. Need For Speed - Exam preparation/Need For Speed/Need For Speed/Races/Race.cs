
using System.Collections.Generic;

    public abstract class Race
    {
        private int length;
        private string route;
        private int prizePool;
        private List<Car> participants;

        protected Race(int length, string route, int prizePool)
        {
            this.Length = length;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new List<Car>();
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public string Route
        {
            get { return this.route; }
            set { this.route = value; }
        }

        public int PrizePool
        {
            get { return this.prizePool; }
            set { this.prizePool = value; }
        }

        public List<Car> Participants
        {
            get { return this.participants; }
            set { this.participants = value; }
        }

        public abstract string PerformancePoints(Car car);
        
        
    }

