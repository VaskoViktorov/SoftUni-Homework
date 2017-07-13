
public class WaterBender : Bender
{
    private float waterClarity;

    public WaterBender(string name, int power,float waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public float WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public override float BenderPower()
    {
        return Power * WaterClarity;
    }

    public override string ToString()
    {
        return base.ToString() + $"Water Clarity: {this.WaterClarity:f2}";
    }
}

