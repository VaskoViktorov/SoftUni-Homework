
public class Engine
{
    public string model;
    public string power;
    public string displacement = "n/a";
    public string efficiency = "n/a";

    public string Displacement { get { return this.displacement; } set { this.displacement = value; } }
    public string Efficiency { get { return this.efficiency; } set { this.efficiency = value; } }

}

