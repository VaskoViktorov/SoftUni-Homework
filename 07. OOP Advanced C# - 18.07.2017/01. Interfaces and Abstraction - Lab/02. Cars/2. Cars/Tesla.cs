
using System.Text;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Model { get; protected set; }

    public string Color { get; protected set; }

    public int Battery { get; protected set; }

    public string Start()
    {
        return "Engine start";
    }
    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(Start());
        sb.Append(Stop());

        return sb.ToString();
    }
}

