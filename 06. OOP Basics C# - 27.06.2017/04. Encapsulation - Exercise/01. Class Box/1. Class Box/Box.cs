
public class Box
{
    private double length;
    private double witdth;
    private double height;

    public Box(double length, double witdth, double height)
    {
        this.length = length;
        this.witdth = witdth;
        this.height = height;
    }
    public string SurfaceArea()
    {
        return $"Surface Area - {2 * this.length * this.witdth + 2 * this.length * this.height + 2 * this.witdth * this.height:f2}";
    }

    public string LateralSurfaceArea()
    {
        return $"Lateral Surface Area - {2 * this.length * this.height + 2 * this.witdth * this.height:f2}";
    }

    public string Volume()
    {
        return $"Volume - {this.length * this.witdth * this.height:f2}";
    }

}

