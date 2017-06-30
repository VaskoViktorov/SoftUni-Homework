
public class Car
{
    private string model;
    private double fuel;
    private double consumption;
    private double distance;

    public string Model { get { return this.model; } set { this.model = value; } }
    public double Fuel { get { return this.fuel; } set { this.fuel = value; } }
    public double Consumption { get { return this.consumption; } set { this.consumption = value; } }
    public double Distance { get { return this.distance; } set { this.distance = 0; } }

    public static bool HasEnoughFuel(string distance, Car one)
    {
       var dist = double.Parse(distance);
        var consumed = dist * one.Consumption;
        if (consumed > one.Fuel)
        {
            return false;
        }       
        return true;
    }

    public static Car UsedFuel(string distance, Car one)
    {
        var dist = double.Parse(distance);
        one.Fuel -= dist * one.Consumption;
        one.distance += dist;

        return one;
    }
}

