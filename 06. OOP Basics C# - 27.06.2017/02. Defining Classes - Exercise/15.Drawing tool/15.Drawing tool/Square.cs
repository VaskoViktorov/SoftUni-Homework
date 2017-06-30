using System;

public class Square : CorDraw
{
    public Square(int sizes)
    {
        this.Sizes = sizes;
    }

    private int sizes;

    public int Sizes
    {
        get
        {
            return this.sizes;
        }
        set
        {
            this.sizes = value;
        }
    }

    public void Draw()
    {
        for (int i = 0; i < this.Sizes; i++)
        {
            if (i == 0 || i == this.Sizes - 1)
            {
                Console.WriteLine($"|{new string('-', this.Sizes)}|");
            }

            else
            {
                Console.WriteLine($"|{new string(' ', this.Sizes)}|");
            }
        }
    }
}
