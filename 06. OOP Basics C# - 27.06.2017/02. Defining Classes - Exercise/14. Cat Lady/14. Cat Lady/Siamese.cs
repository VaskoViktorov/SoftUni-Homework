public class Siamese : Cat
{
    private int earSize;

    public int EarSize
    {
        get
        {
            return this.earSize;
        }
        set
        {
            this.earSize = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Breed} {this.Name} {this.EarSize}";
    }
}
