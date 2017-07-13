
using System.Collections.Generic;
using System.Text;

public class Nation
{
   
    public string NationStatus(List<AirBender> benders, List<AirMonument> monuments, string nationsType)
    {
        StringBuilder builder = new StringBuilder();

        if (benders.Count != 0)
        {
            builder.Append($"{nationsType} Nation\r\nBenders:\r\n");
            foreach (var bender in benders)
            {
                builder.Append($"###Air Bender: {bender.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"{nationsType} Nation\r\nBenders: None\r\n");
        }

        if (monuments.Count != 0)
        {
            builder.Append($"Monuments:\r\n");
            foreach (var monument in monuments)
            {
                builder.Append($"###Air Monument: {monument.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"Monuments: None");
        }

        return builder.ToString();
    }

    public string NationStatus(List<WaterBender> benders, List<WaterMonument> monuments, string nationsType)
    {
        StringBuilder builder = new StringBuilder();


        if (benders.Count != 0)
        {
            builder.Append($"{nationsType} Nation\r\nBenders:\r\n");
            foreach (var bender in benders)
            {
                builder.Append($"###Water Bender: {bender.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"{nationsType} Nation\r\nBenders: None\r\n");
        }

        if (monuments.Count != 0)
        {
            builder.Append($"Monuments:\r\n");
            foreach (var monument in monuments)
            {
                builder.Append($"###Water Monument: {monument.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"Monuments: None");
        }

        return builder.ToString();
    }

    public string NationStatus(List<FireBender> benders, List<FireMonument> monuments, string nationsType)
    {
        StringBuilder builder = new StringBuilder();


        if (benders.Count != 0)
        {
            builder.Append($"{nationsType} Nation\r\nBenders:\r\n");
            foreach (var bender in benders)
            {
                builder.Append($"###Fire Bender: {bender.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"{nationsType} Nation\r\nBenders: None\r\n");
        }

        if (monuments.Count != 0)
        {
            builder.Append($"Monuments:\r\n");
            foreach (var monument in monuments)
            {
                builder.Append($"###Fire Monument: {monument.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"Monuments: None");
        }

        return builder.ToString();
    }

    public string NationStatus(List<EarthBender> benders, List<EarthMonument> monuments, string nationsType)
    {
        StringBuilder builder = new StringBuilder();


        if (benders.Count != 0)
        {
            builder.Append($"{nationsType} Nation\r\nBenders:\r\n");
            foreach (var bender in benders)
            {
                builder.Append($"###Earth Bender: {bender.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"{nationsType} Nation\r\nBenders: None\r\n");
        }

        if (monuments.Count != 0)
        {
            builder.Append($"Monuments:\r\n");
            foreach (var monument in monuments)
            {
                builder.Append($"###Earth Monument: {monument.ToString()}\r\n");
            }
        }
        else
        {
            builder.Append($"Monuments: None");
        }

        return builder.ToString();
    }
}

