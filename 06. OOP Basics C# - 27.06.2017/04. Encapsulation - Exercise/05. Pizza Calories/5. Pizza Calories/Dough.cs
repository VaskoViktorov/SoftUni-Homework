
using System;
using System.Collections.Generic;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    public string FlourType
    {
        get { return this.flourType; }
        set
        {
            List<string> validTypes = new List<string>{ "white", "wholegrain" };
            if (!validTypes.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            List<string> validTypes = new List<string> { "crispy", "chewy", "homemade" };
            if (!validTypes.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < 1 || value>200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }
    public double DoughCalories()
    {       
                 
            var typeMod = 0d;
            var techMod = 0d;

            switch (this.flourType.ToLower())
            {
                case "white":
                    typeMod = 1.5;
                    break;
                case "wholegrain":
                    typeMod = 1.0;
                    break;
            }
            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    techMod = 0.9;
                    break;
                case "chewy":
                    techMod = 1.1;
                    break;
                case "homemade":
                    techMod = 1.0;
                    break;
            }
           
           return (2d * this.weight) *techMod * typeMod;
        
    }

}

