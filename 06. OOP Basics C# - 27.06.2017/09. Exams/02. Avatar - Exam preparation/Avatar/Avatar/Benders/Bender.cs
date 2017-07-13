
public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public abstract float BenderPower();

    public override string ToString()
    {
        return $"{this.Name}, Power: {this.Power}, ";
    }
}

