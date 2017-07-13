
using System;

public class FireBender : Bender
{

    private float heatAggression;

    public FireBender(string name, int power, float heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

   
    public float HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public override float BenderPower()
    {
        return Power*HeatAggression;
    }

    public override string ToString()
    {
        return base.ToString() + $"Heat Aggression: {this.HeatAggression:f2}";
    }
}


