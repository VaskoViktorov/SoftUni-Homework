
using System;
using System.Collections.Generic;
using System.Text;

public class NationsBuilder
{
    private List<AirBender> airBenders;
    private List<WaterBender> waterBenders;
    private List<EarthBender> earthBenders;
    private List<FireBender> fireBenders;
    private List<AirMonument> airMonuments;
    private List<WaterMonument> waterMonuments;
    private List<EarthMonument> earthMonuments;
    private List<FireMonument> fireMonuments;
    private Dictionary<int, string> warRecord;

    public NationsBuilder()
    {
        this.airBenders = new List<AirBender>();
        this.waterBenders = new List<WaterBender>();
        this.earthBenders = new List<EarthBender>();
        this.fireBenders = new List<FireBender>();
        this.airMonuments = new List<AirMonument>();
        this.waterMonuments = new List<WaterMonument>();
        this.earthMonuments = new List<EarthMonument>();
        this.fireMonuments = new List<FireMonument>();
        this.warRecord = new Dictionary<int, string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        switch (benderArgs[1])
        {
            case "Air":
                airBenders.Add(new AirBender(benderArgs[2], int.Parse(benderArgs[3]), float.Parse(benderArgs[4])));
                break;
            case "Water":
                waterBenders.Add(new WaterBender(benderArgs[2], int.Parse(benderArgs[3]), float.Parse(benderArgs[4])));
                break;
            case "Fire":
                fireBenders.Add(new FireBender(benderArgs[2], int.Parse(benderArgs[3]), float.Parse(benderArgs[4])));
                break;
            case "Earth":
                earthBenders.Add(new EarthBender(benderArgs[2], int.Parse(benderArgs[3]), float.Parse(benderArgs[4])));
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        switch (monumentArgs[1])
        {
            case "Air":
                airMonuments.Add(new AirMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
            case "Water":
                waterMonuments.Add(new WaterMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
            case "Fire":
                fireMonuments.Add(new FireMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
            case "Earth":
                earthMonuments.Add(new EarthMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        string result = string.Empty;

        switch (nationsType)
        {
            case "Air":
                result = new Nation().NationStatus(airBenders, airMonuments, nationsType);
                break;
            case "Water":
                result = new Nation().NationStatus(waterBenders, waterMonuments, nationsType);
                break;
            case "Fire":
                result = new Nation().NationStatus(fireBenders, fireMonuments, nationsType);
                break;
            case "Earth":
                result = new Nation().NationStatus(earthBenders, earthMonuments, nationsType);
                break;
        }
        return result.Trim();
    }
    public void IssueWar(string nationsType)
    {
        double airPower = 0d;
        double waterPower = 0d;
        double firePower = 0d;
        double earthPower = 0d;

        if (airBenders.Count != 0)
        {
            foreach (var bender in airBenders)
            {
                airPower += bender.BenderPower();
            }
            if (airMonuments.Count != 0)
            {
                var affinity = 0;
                foreach (var monument in airMonuments)
                {
                    affinity += monument.AirAffinity;
                }
                airPower += airPower * (affinity / 100f);
            }
        }
        if (waterBenders.Count != 0)
        {
            foreach (var bender in waterBenders)
            {
                waterPower += bender.BenderPower();
            }
            if (waterMonuments.Count != 0)
            {
                var affinity = 0;
                foreach (var monument in waterMonuments)
                {
                    affinity += monument.WaterAffinity;
                }
                waterPower += waterPower * (affinity / 100f);
            }
        }
        if (fireBenders.Count != 0)
        {
            foreach (var bender in fireBenders)
            {
                firePower += bender.BenderPower();
            }
            if (fireMonuments.Count != 0)
            {
                var affinity = 0;
                foreach (var monument in fireMonuments)
                {
                    affinity += monument.FireAffinity;
                }
                firePower += firePower * (affinity / 100f);
            }
        }
        if (earthBenders.Count != 0)
        {
            foreach (var bender in earthBenders)
            {
                earthPower += bender.BenderPower();
            }
            if (earthMonuments.Count != 0)
            {
                var affinity = 0;
                foreach (var monument in earthMonuments)
                {
                    affinity += monument.EarthAffinity;
                }
                earthPower += earthPower * (affinity / 100f);
            }
        }
        var firstBattle = Math.Max(airPower, waterPower);
        var secondBattle = Math.Max(firePower, earthPower);
        var winner = Math.Max(firstBattle, secondBattle);
        if (winner.Equals(airPower))
        {
            waterBenders.Clear();
            waterMonuments.Clear();
            fireBenders.Clear();
            fireMonuments.Clear();
            earthBenders.Clear();
            earthMonuments.Clear();
        }
        else if (winner.Equals(waterPower))
        {
            airBenders.Clear();
            airMonuments.Clear();
            fireBenders.Clear();
            fireMonuments.Clear();
            earthBenders.Clear();
            earthMonuments.Clear();
        }
        else if (winner.Equals(firePower))
        {
            airBenders.Clear();
            airMonuments.Clear();
            waterBenders.Clear();
            waterMonuments.Clear();
            earthBenders.Clear();
            earthMonuments.Clear();
        }
        else if (winner.Equals(earthPower))
        {

            airBenders.Clear();
            airMonuments.Clear();
            waterBenders.Clear();
            waterMonuments.Clear();
            fireBenders.Clear();
            fireMonuments.Clear();
        }

        warRecord.Add(warRecord.Count + 1, nationsType);
    }
    public string GetWarsRecord()
    {
        StringBuilder builder = new StringBuilder();
        foreach (var war in warRecord)
        {
            builder.Append($"War {war.Key} issued by {war.Value}\r\n");
        }
        return builder.ToString().Trim();
    }

}

