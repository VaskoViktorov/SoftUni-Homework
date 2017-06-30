public class StreetExtraordinaire : Cat
{
    private int decibels;

    public int Decibels
    {
        get
        {
            return this.decibels;
        }
        set
        {
            this.decibels = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.Decibels}";
    }
}
