
using System;

public class EarthBender : Bender
{

    private float groundSaturation;

    public EarthBender(string name, int power, float groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public float GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }

    public override float BenderPower()
    {
        return Power*GroundSaturation;
    }

    public override string ToString()
    {
        return base.ToString() + $"Ground Saturation: {this.GroundSaturation:f2}";
    }
}

