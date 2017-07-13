
using System;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps) : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public int Laps
    {
        get { return this.laps; }
        set { this.laps = value; }
    }
    public override string PerformancePoints(Car car)
    {
        throw new NotImplementedException();
    }
}

