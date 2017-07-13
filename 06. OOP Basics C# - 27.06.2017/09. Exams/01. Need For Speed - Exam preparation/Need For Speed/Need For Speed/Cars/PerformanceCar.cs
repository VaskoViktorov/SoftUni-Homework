
using System.Collections.Generic;

    public class PerformanceCar : Car
    {
        private List<string> addOns;


        public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this.AddOns = new List<string>();
            base.Horsepower = base.Horsepower + (base.Horsepower *50)/100;
            base.Suspension = base.Suspension - (base.Suspension *25)/100;

        }

        public List<string> AddOns
        {
            get { return this.addOns; }
            set { this.addOns = value; }
        }
        
        public override string ToString()
        {
            if (this.AddOns.Count != 0)
            {
                return base.ToString() + "Add-ons: " + string.Join(", ", this.AddOns);
            }
            return base.ToString() + "Add-ons: None";
        }

        public override void Tuning(int tuneIndex, string addOn)
        {
            AddOns.Add(addOn);
            base.Horsepower += tuneIndex;
            base.Suspension += (tuneIndex *50)/100;
        }

}

