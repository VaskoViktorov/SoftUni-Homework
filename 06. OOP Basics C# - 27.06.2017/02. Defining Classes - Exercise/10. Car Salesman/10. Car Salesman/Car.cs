
using System;

public class Car
{
    public string model;
    public Engine engine;
    public string weight = "n/a";
    public string color = "n/a";

    public string Weight { get { return this.weight; } set { this.weight = value; } }
    public string Color { get { return this.color; } set { this.color = value; } }

    public override string ToString()
    {
        return $"{this.model}:\n  {this.engine.model}:\n    Power: {this.engine.power}\n    Displacement: {this.engine.Displacement}\n" +
               $"    Efficiency: {this.engine.Efficiency}\n    Weight: {this.Weight}\n    Color: {this.Color}";
    }
}

