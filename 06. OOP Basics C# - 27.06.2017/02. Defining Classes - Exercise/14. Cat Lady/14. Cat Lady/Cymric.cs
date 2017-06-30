public class Cymric : Cat
{
    private double furLength;

    public double FurLength
    {
        get
        {
            return this.furLength;
        }
        set
        {
            this.furLength = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.FurLength:f2}";
    }
}