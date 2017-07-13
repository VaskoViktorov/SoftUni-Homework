
using System;

public class AirBender:Bender
{
    private float aerialIntegrity;

    public AirBender(string name, int power, float aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }


    public float AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        set { this.aerialIntegrity = value; }
    }

    public override float BenderPower()
    {
        return base.Power*AerialIntegrity;
    }

    public override string ToString()
    {
        return base.ToString() + $"Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}

