using System;
public class Scale<T> where T : IComparable<T>
{

    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public T Left { get; }

    public T Right { get; }

    public T GetHavier()
    {
        if (Left.CompareTo(Right) > 0)
        {
            return Left;
        }
        else if (Left.CompareTo(Right) < 0)
        {
            return Right;
        }

        return default(T);
    }


}

