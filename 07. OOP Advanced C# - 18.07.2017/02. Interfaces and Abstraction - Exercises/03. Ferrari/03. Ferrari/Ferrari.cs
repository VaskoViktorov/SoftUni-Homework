
using System.Text;

public class Ferrari : ICar
{
    private string driverName;

    public Ferrari(string driverName)
    {
        DriverName = driverName;
    }

    public string DriverName { get; protected set; }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("488-Spider/");
        sb.Append(Brakes());
        sb.Append("/");
        sb.Append(GasPedal());
        sb.Append($"/{DriverName}");

        return sb.ToString();
    }
}

